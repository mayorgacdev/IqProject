using EconomicMF.Domain.DTO;
using EconomicMF.Domain.Entities.FlowTool;
using EconomicMF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using EconomicMF.Domain.Entities.FlowTool.ClasesFlujo;
using System.Data;
using Excel.FinancialFunctions;
using System.ComponentModel;
using System.Collections;
using EconomicMF.Domain.Enums.Others;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Entities.Flows;

namespace EconomicMF.AppCore.Processes
{
    public static class ProjectCalculations
    {
        public static Project GetBestProject(List<Project> projects, int IdSolution)
        {
            List<Project> projects1 = new List<Project>();
            foreach (var proj in projects)
            {
                if (proj.SolutionId == IdSolution)
                {
                    projects1.Add(proj);
                }
            }
            Project project = new Project();
            decimal vpn = 0;
            foreach (var proj in projects1)
            {
                decimal vpn1 = VPN(FNE(proj), TMAR(proj));
                if (vpn < vpn1)
                {
                    project = proj;
                }
            }
            return project;
        }
        
        /*public static DataTable Financiamientos(Project p)
        {
            List<financiamiento> financials = new List<financiamiento>();
            
            foreach (var item in p.EntidadInvs)
            {
                financials.Add(new financiamiento() { Nombre = item.Name, Aportacion = item.Contribution });
            }
            Convertir<financiamiento> convertir = new Convertir<financiamiento>();
            return convertir.ConvertirListaToDataTable(financials);
        }*/
        public static DataTable DatosPastel(Project p)
        {
            List<PastelData> datas = new List<PastelData>();
            decimal denom = GastosN(p).Sum(x => x.Gasto) + costosN(p).Sum(x => x.costo) + PrestamosN(p).Sum(x => x.Monto);
            datas.Add(new PastelData() { Nombres = "Gastos", Valor = GastosN(p).Sum(x => x.Gasto) / denom });
            datas.Add(new PastelData() { Nombres = "Costos", Valor = costosN(p).Sum(x => x.costo) / denom });
            datas.Add(new PastelData() { Nombres = "Amortizacion", Valor = PrestamosN(p).Sum(x => x.Monto) / denom });
            Convertir<PastelData> convertir = new Convertir<PastelData>();
            return convertir.ConvertirListaToDataTable(datas);
        }
        public static DataTable DatosProjecto(Project p, bool mejor)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("VPN");
            dt.Columns.Add("TIR");
            dt.Columns.Add("TMAR");
            dt.Columns.Add("Gastos");
            dt.Columns.Add("Costos");
            dt.Columns.Add("Amortizacion");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Financiamiento");
            dt.Columns.Add("Periodo");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Tipo");
            dt.Columns.Add("NombreInv");
            dt.Columns.Add("Foto");
            DataRow data = dt.NewRow();
            data["TIR"] = Math.Round(TIR(FNE(p)), 2);
            data["TMAR"] = Math.Round(TMAR(p), 2);
            /*decimal total = GastosN(p).Sum(i => i.Gasto) + ingresosN(p).Sum(i => i.Monto) + ActivosN(p).Sum(i => i.Monto) + costosN(p).Sum(i => i.costo)
                + PrestamosN(p).Sum(i => i.Monto);*/
            data["VPN"] = Math.Round(VPN(FNE(p), TIR(FNE(p))), 2);
           
            decimal s = GastosN(p).Sum(i => i.Gasto);
            decimal s1 = costosN(p).Sum(i => i.costo);
            decimal s2 = ActivosN(p).Sum(i => i.Monto);
            data["Gastos"] = 2000;// / total * cien) ;
            data["Costos"] = costosN(p).Sum(i => i.costo);// / total * cien);
            data["Amortizacion"] = 3000;// / total * cien);
            data["Nombre"] = p.Name;
            data["Periodo"] = p.Duration;
            data["Tipo"] = p.Period;
            data["Descripcion"] = mejor ? "Este proyecto es el mejor entre la solucion" : "Hay un mejor proyecto entre la solucion";
            // data["NombreInv"] = p.EntidadInvs.ToList()[1].Name;
            //data["Foto"] = p.EntidadInvs.ToList()[1].ProfileImage;
            dt.Rows.Add(data);
            return dt;
        }
        public static DataTable FlujosReport(Project p)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Flujo");
            dt.Columns.Add("Numero");
            for (int i = 0; i < FNE(p).Count; i++)
            {
                DataRow data = dt.NewRow();
                data["Numero"] = i;
                data["Flujo"] = Math.Round((decimal)FNE(p)[i].FNE, 2);
                dt.Rows.Add(data);
            }

            return dt;
        }
        public static DataTable AllFNE(Project p, FlujoGeneral flujo)
        {
            DataTable dt = new DataTable();
            List<Flujo> flujos = FNE(p);
            Convertir<Flujo> convertir = new Convertir<Flujo>();
            dt = GetDataDTO(GetGeneral(p));
            DataRow data = dt.NewRow();
            data["Conceptos:"] = "Utilidad antes de IR";
            for (int i = 0; i < flujos.Count; i++)
            {

                data[i.ToString()] = flujos[i].Utilidad_antes_de_IR;
            }
            dt.Rows.Add(data);
            data = dt.NewRow();
            data["Conceptos:"] = "IR";
            for (int i = 0; i < flujos.Count; i++)
            {

                data[i.ToString()] = flujos[i].IR;
            }
            dt.Rows.Add(data);
            data = dt.NewRow();
            data["Conceptos:"] = "Utilidades despues de impuestos";
            for (int i = 0; i < flujos.Count; i++)
            {

                data[i.ToString()] = flujos[i].Utilidad_después_de_IR;
            }
            dt.Rows.Add(data);
            foreach (var item in flujo.activosGenerals)
            {
                DataRow dr = dt.NewRow();
                if (item.Nombre == "Terreno")
                {
                    dr["Conceptos:"] = item.Nombre;
                }
                else if (item.Nombre.Contains("Diferida") || item.Nombre.Contains("Diferido"))
                {
                    dr["Conceptos:"] = item.Nombre;
                }
                else
                {
                    dr["Conceptos:"] = "Depreciacion de " + item.Nombre;
                }
                for (int i = 0; i < item.Monto.Count; i++)
                {
                    dr[i.ToString()] = item.Monto[i];
                }
                dt.Rows.Add(dr);
            }

            data = dt.NewRow();
            data["Conceptos:"] = "Amortización";
            for (int i = 0; i < flujos.Count; i++)
            {

                data[i.ToString()] = flujos[i].Amortización_;
            }
            dt.Rows.Add(data);
            data = dt.NewRow();
            data["Conceptos:"] = "Valor residual";
            for (int i = 0; i < flujos.Count; i++)
            {

                data[i.ToString()] = flujos[i].ValorResidual;
            }
            dt.Rows.Add(data);
            data = dt.NewRow();
            data["Conceptos:"] = "Recuperación de capital de trabajo";
            for (int i = 0; i < flujos.Count; i++)
            {

                data[i.ToString()] = flujos[i].Recuperación_de_capital_de_Trabajo;
            }
            dt.Rows.Add(data);
            foreach (var item in flujo.prestamosGenereals)
            {
                DataRow dr = dt.NewRow();
                dr["Conceptos:"] = "Saldo insoluto a " + item.Nombre;
                for (int i = 0; i < item.AbonoDeuda.Count; i++)
                {
                    dr[i.ToString()] = item.SaldoInsoluto;
                }
                dt.Rows.Add(dr);
            }
            foreach (var item in flujo.prestamosGenereals)
            {
                DataRow dr = dt.NewRow();
                dr["Conceptos:"] = "Abono a la deuda de " + item.Nombre;
                for (int i = 0; i < item.AbonoDeuda.Count; i++)
                {
                    dr[i.ToString()] = item.AbonoDeuda[i];
                }
                dt.Rows.Add(dr);
            }
            data = dt.NewRow();
            data["Conceptos:"] = "Inverion Total";
            for (int i = 0; i < flujos.Count; i++)
            {

                data[i.ToString()] = flujos[i].Inversion;
            }
            dt.Rows.Add(data);
            data = dt.NewRow();
            data["Conceptos:"] = "FNE";
            for (int i = 0; i < flujos.Count; i++)
            {

                data[i.ToString()] = flujos[i].FNE;
            }
            dt.Rows.Add(data);
            return dt;
        }
        public static decimal VPN(List<Flujo> flujosnetos, decimal tasa)
        {
            tasa /= 100;
            List<double> fne = new List<double>();

            foreach (var item in flujosnetos)
            {
                fne.Add((double)item.FNE);
            }

            IEnumerable<double> doubles = fne;

            return (decimal)Financial.Npv((double)tasa, doubles);
        }
        public static decimal TMAR(Project project)
        {
            List<decimal> tasas = new List<decimal>();
            foreach (var inv in project.InvestmentEntities)
            {
                tasas.Add((decimal)(inv.IsPorcentage ? inv.Contribution * inv.Rate : inv.Contribution / 100 * inv.Rate));
            }
            return tasas.Sum();
        }
        public static decimal TIR(List<Flujo> flujosnetos, decimal adivinar = (decimal)10)
        {
            adivinar /= 100;
            List<double> fne = new List<double>();

            foreach (var item in flujosnetos)
            {
                fne.Add((double)item.FNE);
            }

            IEnumerable<double> doubles = fne;
            return (decimal)Financial.Irr(doubles, 0.1);
        }
        public static decimal CAUE(List<Flujo> flujosnetos, decimal TMAR)
        {
            TMAR /= 100;
            List<double> fne = new List<double>(flujosnetos.Count);
            for (int i = 0; i <= fne.Count; i++)
            {
                fne[i] = -1 * (double)(flujosnetos[i].FNE - flujosnetos[i].IngresosNetos) / Math.Pow(1 + (double)TMAR, i);
            }

            return (decimal)fne.Sum() * (TMAR * (decimal)Math.Pow(1 + (double)TMAR, fne.Count - 1)) /
                ((decimal)Math.Pow(1 + (double)TMAR, fne.Count - 1) - 1);

        }

        // Depreciación
        public static List<DLR> DLR(decimal Costo, int N, decimal VR = 0)
        {
            decimal depreciacion = (Costo - VR) / N;
            List<DLR> dLRs = new List<DLR>();
            for (int i = 0; i <= N; i++)
            {

                DLR dLR = new DLR()
                {
                    Período = i,
                    DepreciaciónPorPeríodo = i == 0 ? 0 : depreciacion,
                    DepreciaciónAcumulada = i == 0 ? 0 : depreciacion * i,
                    valorLibros = i == 0 ? Costo : Costo - depreciacion * i,
                };
                dLRs.Add(dLR);
            }
            return dLRs;
        }

        //Depreciación
        public static List<DSDA> DSDA(decimal Costo, int N, decimal VR = 0)
        {
            List<DSDA> dSDAs = new List<DSDA>();
            for (int i = 0; i <= N; i++)
            {
                decimal depreciacion = i == 0 ? 0 : (decimal)Financial.Syd((double)Costo, (double)VR, N, i);
                DSDA dSDA = new DSDA()
                {
                    Período = i,
                    Fraccion = i == 0 ? "0" : ((2 * (N - i + 1)).ToString() + "/" + (N * (N + 1)).ToString()).ToString(),
                    CantidadDepreciableTotal = i == 0 ? 0 : Costo - VR,
                    DepreciaciónPorPeríodo = i == 0 ? 0 : depreciacion,
                    ValorLibro = i == 0 ? Costo : Costo - depreciacion

                };
                dSDAs.Add(dSDA);
            }
            return dSDAs;
        }
        //Microsoft.VisualBasic.Financial.
        //Depreciación
        public static List<DDDS> DDDS(decimal Costo, int N, decimal VR = 0, decimal Factor1 = 2)
        {
            List<DDDS> dDDs = new List<DDDS>();
            for (int i = 0; i <= N; i++)
            {
                decimal depreciacion = (decimal)Microsoft.VisualBasic.Financial.DDB((double)Costo, (double)VR, N, 2);
                //depreciacion /= i == 0 ? 1 : i;

                DDDS dDD = new DDDS()
                {
                    Período = i,
                    Tasa = ((2 / N) * 100).ToString() + "%",
                    DepreciaciónPorPeríodo = i == 0 ? 0 : (decimal)depreciacion,
                    ValorLibro = i == 0 ? Costo : Costo - (decimal)depreciacion
                };
                dDDs.Add(dDD);
            }
            return dDDs;
        }

        // Prestamos carnal
        public static List<Amortizacion> AmortizacionNivelada(decimal prestamo, int N, decimal tasa)
        {
            List<Amortizacion> amortizacion = new List<Amortizacion>();
            decimal cuota = (decimal)Microsoft.VisualBasic.Financial.Pmt((double)tasa / 100, N, -(double)prestamo);
            for (int i = 0; i <= N; i++)
            {
                decimal interes = i == 0 ? 0 : prestamo * (tasa / 100);
                decimal abono = cuota - interes;
                prestamo = i == 0 ? prestamo : prestamo - abono;
                Amortizacion amort = new Amortizacion()
                {
                    Período = i,
                    Cuota = i == 0 ? 0 : Math.Round(cuota, 2),
                    Interes = Math.Round(interes, 2),
                    AbonoDeuda = i == 0 ? 0 : Math.Round(abono, 2),
                    SaldoInsoluto = Math.Round(prestamo, 2)
                };
                amortizacion.Add(amort);
            }
            return amortizacion;
        }

        //Prestamos carnal
        public static List<Amortizacion> AmortizacionProporcional(decimal prestamo, int N, decimal tasa)
        {
            decimal abono = prestamo / N;
            List<Amortizacion> amortizacion = new List<Amortizacion>();
            for (int i = 0; i <= N; i++)
            {

                decimal interes = i == 0 ? 0 : prestamo * (tasa / 100);
                decimal cuota = i == 0 ? 0 : interes + abono;
                prestamo = i == 0 ? prestamo : prestamo - abono;
                Amortizacion amort = new Amortizacion()
                {
                    Período = i,
                    Cuota = Math.Round(cuota, 2),
                    Interes = Math.Round(interes),
                    AbonoDeuda = i == 0 ? 0 : Math.Round(abono),
                    SaldoInsoluto = Math.Round(prestamo)
                };
                amortizacion.Add(amort);
            }
            return amortizacion;
        }
        public static List<Costo> costosN(Project project)
        {
            List<Costo> CostosN = new List<Costo>();
            for (int i = 0; i <= project.Duration; i++)
            {
                Costo costo = new Costo()
                {
                    costo = 0
                };
                CostosN.Add(costo);
            }
            foreach (var cost in project.ProjectCosts)
            {
                if (cost.TypeGrowth == TipoCrecimiento.Geometrico.ToString())
                {
                    cost.Growth /= 100;
                    int j = 0;
                    for (int i = cost.Start; i <= cost.End; i++)
                    {
                        CostosN[i].costo += (cost.Cost * (decimal)Math.Pow((double)(1 + cost.Growth), j++));
                    }
                }
                else if (cost.TypeGrowth == TipoCrecimiento.Aritmetico.ToString())
                {
                    int j = 0;
                    for (int i = cost.Start; i <= cost.End; i++)
                    {
                        CostosN[i].costo += ((decimal)(cost.Cost + j++ * cost.Growth));
                    }
                }
                else
                {
                    for (int i = cost.Start; i <= cost.End; i++)
                    {
                        CostosN[i].costo += ((decimal)(cost.Cost));
                    }
                }
            }
            return CostosN;
        }
        public static List<Gastos> GastosN(Project project)
        {
            List<Gastos> gastosN = new List<Gastos>();
            for (int i = 0; i <= project.Duration; i++)
            {
                Gastos gastos = new Gastos()
                {
                    Gasto = 0,
                };
                gastosN.Add(gastos);
            }
            foreach (var gasto in project.ProjectExpenses)
            {
                if (gasto.TypeGrowth == TipoCrecimiento.Geometrico.ToString())
                {
                    gasto.Growth /= 100;
                    int j = 0;
                    for (int i = gasto.Start; i <= gasto.End; i++)
                    {
                        gastosN[i].Gasto += (gasto.Expense * (decimal)Math.Pow((double)(1 + gasto.Growth), j++));
                    }
                }
                else if (gasto.TypeGrowth == TipoCrecimiento.Aritmetico.ToString())
                {
                    int j = 0;
                    for (int i = gasto.Start; i <= gasto.End; i++)
                    {
                        gastosN[i].Gasto += ((decimal)(gasto.Expense + j++ * gasto.Growth));
                    }
                }
                else
                {
                    for (int i = gasto.Start; i <= gasto.End; i++)
                    {
                        gastosN[i].Gasto += gasto.Expense;
                    }
                }

            }
            return gastosN;
        }

        public static List<Prestamos> PrestamosN(Project project)
        {
            List<decimal> prestamosN = new List<decimal>();
            List<decimal> Abono = new List<decimal>();
            List<Prestamos> prestamos = new List<Prestamos>();
            for (int i = 0; i <= project.Duration; i++)
            {
                prestamosN.Add(0);
                Abono.Add(0);
            }
            for (int i = 0; i < project.InvestmentEntities.Count; i++)
            {
                // Aqui quite una onda RecoveryCT ponela 
                project.InvestmentEntities[i].Contribution = project.InvestmentEntities[i].IsPorcentage ?
                    ( /** estaba aqui*/ project.InvestmentArea.Sum(a => a.Amount)) *
                    (project.InvestmentEntities.ToList()[i].Contribution / 100) : project.InvestmentEntities.ToList()[i].Contribution;
            }
            foreach (var prest in project.InvestmentEntities)
            {
                if (prest.MoneyLoan)
                {
                    decimal tasa = (decimal)(prest.IsPorcentage ? prest.Rate : (prest.Rate / 100));

                    for (int i = 0; i <= project.Duration; i++)
                    {/*
                        if (prest.TipoDeAmortizacion is TipoDeAmortizacion.AmortizacionNivelada)
                        {

                            prestamosN[i] += AmortizacionNivelada((decimal)prest.Contribution, prest.LoanTerm, tasa)[i].Interes;
                            Abono[i] += AmortizacionNivelada((decimal)prest.Contribution, prest.LoanTerm, tasa)[i].AbonoDeuda;

                        }
                        else
                        {

                            prestamosN[i] += AmortizacionProporcional((decimal)prest.Contribution, prest.LoanTerm, tasa)[i].Interes;
                            Abono[i] += AmortizacionProporcional((decimal)prest.Contribution, prest.LoanTerm, tasa)[i].AbonoDeuda;
                        }*/
                    }
                    //prestamos.Add(prestamos1);
                }


            }
            for (int i = 0; i <= project.Duration; i++)
            {
                Prestamos prestamos1 = new Prestamos()
                {
                    AbonoDeuda = Abono[i],
                    Monto = prestamosN[i],
                    Nombre = "Prestamos Netos"
                };
                prestamos.Add(prestamos1);
            }
            return prestamos;
        }
        private static int GetVidaUtil(string name, int periodo)
        {
            int vidautil = 1;
            switch (name)
            {
                case "Ascensores":
                    vidautil = (int)VidaUtilActivos.Ascensores;
                    break;
                case "Edificios_Industriales":
                    vidautil = (int)VidaUtilActivos.Edificios_Industriales;
                    break;
                case "Edificios_Comerciales":
                    vidautil = (int)VidaUtilActivos.Edificios_Comerciales;
                    break;
                case "Residencia_Del_Propietario":
                    vidautil = (int)VidaUtilActivos.Residencia_Del_Propietario;
                    break;
                case "Edificios_De_Alquiler":
                    vidautil = (int)VidaUtilActivos.Edificios_De_Alquiler;
                    break;
                case "Instalaciones_fijas_en_explotacion_agropecuaria":
                    vidautil = (int)VidaUtilActivos.Instalaciones_fijas_en_explotacion_agropecuaria;
                    break;
                case "Colectivo_De_Carga":
                    vidautil = (int)VidaUtilActivos.Colectivo_De_Carga;
                    break;
                case "Vehiculo_De_Empresas_de_Alquiler":
                    vidautil = (int)VidaUtilActivos.Vehiculo_De_Empresas_de_Alquiler;
                    break;
                case "Otros_Equipos_de_Transporte":
                    vidautil = (int)VidaUtilActivos.Otros_Equipos_de_Transporte;
                    break;
                case "Maquinaria_fija_en_bien_inmovil":
                    vidautil = (int)VidaUtilActivos.Maquinaria_fija_en_bien_inmovil;
                    break;
                case "Maquinaria_no_adherida_permanentemente":
                    vidautil = (int)VidaUtilActivos.Maquinaria_no_adherida_permanentemente;
                    break;
                case "Otras_Maquinarias_y_Equipo":
                    vidautil = (int)VidaUtilActivos.Otras_Maquinarias_y_Equipo;
                    break;
                case "Equipos_de_Empresas_Agroindustriales":
                    vidautil = (int)VidaUtilActivos.Equipos_de_Empresas_Agroindustriales;
                    break;
                case "Equipos_Agricolas":
                    vidautil = (int)VidaUtilActivos.Equipos_Agricolas;
                    break;
                case "Mobilario_y_Equipo_de_Oficina":
                    vidautil = (int)VidaUtilActivos.Mobilario_y_Equipo_de_Oficina;
                    break;
                case "Equipos_de_Comunicacion":
                    vidautil = (int)VidaUtilActivos.Equipos_de_Comunicacion;
                    break;
                case "Equipos_de_Computacion":
                    vidautil = (int)VidaUtilActivos.Equipos_de_Computacion;
                    break;
                case "Equipos_para_Medio_de_comunicacion":
                    vidautil = (int)VidaUtilActivos.Equipos_para_Medio_de_comunicacion;
                    break;
                case "Elevadores":
                    vidautil = (int)VidaUtilActivos.Elevadores;
                    break;
                case "Unidad_de_Aire_Acondicionado":
                    vidautil = (int)VidaUtilActivos.Unidad_de_Aire_Acondicionado;
                    break;
                case "Otros_bienes_muebles":
                    vidautil = (int)VidaUtilActivos.Otros_bienes_muebles;
                    break;
            }
            return vidautil * periodo;
        }
        public static decimal GetValorResidual(Project project)
        {
            decimal valorResidual = 0;
            foreach (var a in project.InvestmentArea)
            {
                valorResidual = a.Name == VidaUtilActivos.Terreno.ToString() ? a.Amount : 0;
            }
            return GetActivosGenerals(project).Sum(x => x.ValorResidual) + valorResidual;
        }
        public static List<Activos> ActivosN(Project project)
        {
            int vidautil = 0;
            int periodo = (int)Enum.GetValues<Periodo>().Where(a => a.ToString() == project.Period).ToList()[0];

            List<Activos> activosN = new List<Activos>();
            for (int i = 0; i <= project.Duration; i++)
            {
                Activos prest = new Activos()
                {
                    Monto = 0,
                };
                activosN.Add(prest);
            }
            foreach (var depre in project.Assets)
            {
                vidautil = GetVidaUtil(depre.Name, periodo);
                if (depre.IsActive)
                {
                    for (int i = 0; i <= vidautil - 1; i++)
                    {
                        if (depre.DepreciationRate == "LR")
                        {
                            activosN[i].Monto += DLR(depre.Amount, vidautil, depre.AmountResidual)[i].DepreciaciónPorPeríodo;
                        }
                        if (depre.DepreciationRate == "DSD")
                        {
                            activosN[i].Monto += DDDS(depre.Amount, vidautil, depre.AmountResidual, 2)[i].DepreciaciónPorPeríodo;
                        }
                        else
                        {
                            activosN[i].Monto += DSDA(depre.Amount, vidautil, depre.AmountResidual)[i].DepreciaciónPorPeríodo;
                        }
                    }
                }

            }
            return activosN;
        }
        public static List<Ingresos> ingresosN(Project project)
        {
            List<Ingresos> IngresosN = new List<Ingresos>();
            for (int i = 0; i <= project.Duration; i++)
            {
                Ingresos prest = new()
                {
                    Monto = 0,
                };
                IngresosN.Add(prest);
            }
            foreach (var ing in project.ProjectEntries)
            {
                if (ing.TypeGrowth == TipoCrecimiento.Geometrico.ToString())
                {
                    ing.Growth /= 100;
                    int j = 0;
                    for (int i = ing.Start; i <= ing.End; i++)
                    {
                        IngresosN[i].Monto += (ing.Entry * (decimal)Math.Pow((double)(1 + ing.Growth), j++));
                    }
                }
                else if (ing.TypeGrowth == TipoCrecimiento.Aritmetico.ToString())
                {
                    int j = 0;
                    for (int i = ing.Start; i <= ing.End; i++)
                    {
                        IngresosN[i].Monto += ((decimal)(ing.Entry + j++ * ing.Growth));
                    }
                }
                else
                {
                    for (int i = ing.Start; i <= ing.End; i++)
                    {
                        IngresosN[i].Monto += ((decimal)(ing.Entry));
                    }
                }
            }
            return IngresosN;
        }
        public static List<Flujo> FNE(Project project)
        {

            List<Flujo> flujoefectivos = new List<Flujo>();
            List<Costo> CostosN = costosN(project);
            List<Gastos> gastosN = GastosN(project);
            List<Prestamos> prestamosN = PrestamosN(project);
            List<Activos> activosN = ActivosN(project);
            List<decimal> Diferido = new List<decimal>();
            for (int i = 0; i <= project.Duration; i++)
            {
                Diferido.Add(0);
            }
            foreach (var d in project.InvestmentArea)
            {
                if (d.IsDiferida)
                {
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        Diferido[i] += i != 0 ? d.Amount / project.Duration : 0;
                    }
                }
            }
            List<Ingresos> IngresosN = ingresosN(project);
            List<decimal> PrestamosNetos = new List<decimal>();
            for (int i = 0; i <= project.Duration; i++)
            {
                PrestamosNetos.Add(0);
            }
            for (int i = 0; i < project.InvestmentEntities.Count; i++)
            {
                if (project.InvestmentEntities[i].MoneyLoan)
                {
                    PrestamosNetos[i] += (decimal)project.InvestmentEntities.ToList()[i].Contribution;
                }
            }

            for (int i = 0; i <= project.Duration; i++)
            {
                int a = i;
                Flujo flujoefectivo = new Flujo()
                {
                    Concepto = i,
                    Inversion = i == 0 ? decimal.Round(project.InvestmentArea.Sum(a => a.Amount) + project.RecoveryCt, 2) : 0,
                    ValorResidual = i == project.Duration ? GetValorResidual(project) : null,
                };

                flujoefectivo.IngresosNetos = decimal.Round(IngresosN[i].Monto, 2);
                flujoefectivo.PrestamosNetos = decimal.Round(PrestamosNetos[i], 2);
                flujoefectivo.CostosNetos = decimal.Round(CostosN[i].costo, 2);
                flujoefectivo.GastosNetos = decimal.Round(gastosN[i].Gasto, 2);
                flujoefectivo.InterésesNetos = decimal.Round(prestamosN[i].Monto, 2);
                flujoefectivo.Abono_a_la_deuda = decimal.Round(prestamosN[i].AbonoDeuda, 2);
                flujoefectivo.Amortización = decimal.Round(Diferido[i], 2);
                flujoefectivo.Amortización_ = decimal.Round(Diferido[i], 2);
                flujoefectivo.Depreciación = decimal.Round(activosN[i].Monto, 2);
                flujoefectivo.Depreciación_ = decimal.Round(activosN[i].Monto, 2);
                decimal total = IngresosN[i].Monto - CostosN[i].costo - gastosN[i].Gasto - prestamosN[i].Monto - activosN[i].Monto - Diferido[i];
                flujoefectivo.Utilidad_antes_de_IR = decimal.Round(total, 2);
                flujoefectivo.IR = decimal.Round(total * (decimal)0.3, 2);
                flujoefectivo.Recuperación_de_capital_de_Trabajo = i == project.Duration ? project.RecoveryCt : 0;
                flujoefectivo.Utilidad_después_de_IR = decimal.Round(total - (total * (decimal)0.3), 2);
                decimal neto = (decimal)(flujoefectivo.Utilidad_después_de_IR + activosN[i].Monto
                    + (i == project.Duration ? project.RecoveryCt : 0) - prestamosN[i].AbonoDeuda - flujoefectivo.Inversion + Diferido[i] + PrestamosNetos[i]);
                neto = i == project.Duration ? GetValorResidual(project) + neto : neto;
                flujoefectivo.FNE = neto;
                flujoefectivo.FNE_Acumulado = i == 1 ? (decimal)flujoefectivo.FNE : (decimal)(i == 0 ? 0 : flujoefectivos[--a].FNE_Acumulado + neto);
                flujoefectivos.Add(flujoefectivo);

            }
            return flujoefectivos;
        }
        public static FlujoGeneral GetGeneral(Project project)
        {
            FlujoGeneral flujoGeneral = new FlujoGeneral()
            {
                costoGenerals = GetCostoGenerals(project),
                gastosGenerals = GetGastosGenerals(project),
                activosGenerals = GetActivosGenerals(project),
                ingresosGenerals = GetIngresosGenerals(project),
                prestamosGenereals = GetPrestamosGenerals(project)
            };
            return flujoGeneral;
        }
        public static DataTable GetDataDTO(FlujoGeneral flujo)
        {
            DataTable data = new DataTable();
            data.Columns.Add("Conceptos:");
            int count = 0;
            if (flujo.gastosGenerals.Count != 0)
            {
                count = flujo.gastosGenerals[0].Monto.Count;
            }
            else if (flujo.ingresosGenerals.Count != 0)
            {
                count = flujo.ingresosGenerals[0].Monto.Count;
            }
            for (int i = 0; i < count; i++)
            {
                data.Columns.Add((i).ToString());
            }
            foreach (var item in flujo.ingresosGenerals)
            {
                DataRow dr = data.NewRow();
                dr["Conceptos:"] = item.Nombre;
                for (int i = 0; i < item.Monto.Count; i++)
                {
                    dr[i.ToString()] = item.Monto[i];
                }
                data.Rows.Add(dr);
            }
            foreach (var item in flujo.costoGenerals)
            {
                DataRow dr = data.NewRow();
                dr["Conceptos:"] = item.Nombre;
                for (int i = 0; i < item.Monto.Count; i++)
                {
                    dr[i.ToString()] = item.Monto[i];
                }
                data.Rows.Add(dr);
            }
            foreach (var item in flujo.gastosGenerals)
            {
                DataRow dr = data.NewRow();
                dr["Conceptos:"] = item.Nombre;
                for (int i = 0; i < item.Monto.Count; i++)
                {
                    dr[i.ToString()] = item.Monto[i];
                }
                data.Rows.Add(dr);
            }
            foreach (var item in flujo.prestamosGenereals)
            {
                DataRow dr = data.NewRow();
                dr["Conceptos:"] = "Interes de " + item.Nombre;
                for (int i = 0; i < item.Interes.Count; i++)
                {
                    dr[i.ToString()] = item.Interes[i];
                }
                data.Rows.Add(dr);
            }
            foreach (var item in flujo.activosGenerals)
            {
                DataRow dr = data.NewRow();
                if (item.Nombre == "Terreno")
                {
                    dr["Conceptos:"] = item.Nombre;
                }
                else if (item.Nombre.Contains("Diferida") || item.Nombre.Contains("Diferido"))
                {
                    dr["Conceptos:"] = item.Nombre;
                }
                else
                {
                    dr["Conceptos:"] = "Depreciacion de " + item.Nombre;
                }
                for (int i = 0; i < item.Monto.Count; i++)
                {
                    dr[i.ToString()] = item.Monto[i];
                }
                data.Rows.Add(dr);
            }

            foreach (var item in flujo.prestamosGenereals)
            {
                DataRow dr = data.NewRow();
                dr["Conceptos:"] = "Abono a la deuda de " + item.Nombre;
                for (int i = 0; i < item.AbonoDeuda.Count; i++)
                {
                    dr[i.ToString()] = item.AbonoDeuda[i];
                }
                data.Rows.Add(dr);
            }

            return data;
        }
        public static List<CostoGeneral> GetCostoGenerals(Project project)
        {
            List<CostoGeneral> costos = new List<CostoGeneral>();
            // List<decimal> CostosN = new List<decimal>();

            foreach (var cost in project.ProjectCosts)
            {

                if (cost.TypeGrowth == TipoCrecimiento.Geometrico.ToString())
                {
                    CostoGeneral costo = new CostoGeneral()
                    {
                        Monto = new List<decimal>(),
                        Nombre = cost.CostType
                    };
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        costo.Monto.Add(0);
                    }
                    cost.Growth /= 100;
                    int j = 0;
                    for (int i = cost.Start; i <= cost.End; i++)
                    {
                        costo.Monto[i] = Math.Round((cost.Cost * (decimal)Math.Pow((double)(1 + cost.Growth), j++)), 2);
                    }
                    costos.Add(costo);
                }
                else if (cost.TypeGrowth == TipoCrecimiento.Aritmetico.ToString())
                {
                    CostoGeneral costo = new CostoGeneral()
                    {
                        Monto = new List<decimal>(),
                        Nombre = cost.CostType
                    };
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        costo.Monto.Add(0);
                    }
                    int j = 0;
                    for (int i = cost.Start; i <= cost.End; i++)
                    {
                        costo.Monto[i] = Math.Round(((decimal)(cost.Cost + j++ * cost.Growth)), 2);

                    }
                    costos.Add(costo);
                }
                else
                {
                    CostoGeneral costo = new CostoGeneral()
                    {
                        Monto = new List<decimal>(),
                        Nombre = cost.CostType
                    };
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        costo.Monto.Add(0);
                    }
                    for (int i = cost.Start; i <= cost.End; i++)
                    {
                        costo.Monto[i] = Math.Round(((decimal)(cost.Cost)), 2);
                    }
                    costos.Add(costo);
                }


            }
            return costos;
        }
        public static List<GastosGeneral> GetGastosGenerals(Project project)
        {
            List<GastosGeneral> gastos = new List<GastosGeneral>();

            foreach (var gast in project.ProjectExpenses)
            {

                if (gast.TypeGrowth == TipoCrecimiento.Geometrico.ToString())
                {
                    GastosGeneral gasto = new GastosGeneral()
                    {
                        Monto = new List<decimal>(),
                        Nombre = gast.TypeExpense
                    };
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        gasto.Monto.Add(0);
                    }
                    gast.Growth /= 100;
                    int j = 0;
                    for (int i = gast.Start; i <= gast.End; i++)
                    {
                        gasto.Monto[i] = Math.Round((i == 0 ? 0 : gast.Expense * (decimal)Math.Pow((double)(1 + gast.Growth), j++)), 2);
                    }
                    gastos.Add(gasto);
                }
                else if (gast.TypeGrowth == TipoCrecimiento.Aritmetico.ToString())
                {
                    GastosGeneral gasto = new GastosGeneral()
                    {
                        Monto = new List<decimal>(),
                        Nombre = gast.TypeExpense
                    };
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        gasto.Monto.Add(0);
                    }
                    int j = 0;
                    for (int i = gast.Start; i <= gast.End; i++)
                    {
                        gasto.Monto[i] = Math.Round((i == 0 ? 0 : (decimal)(gast.Expense + j++ * gast.Growth)), 2);

                    }
                    gastos.Add(gasto);
                }
                else
                {
                    GastosGeneral gasto = new GastosGeneral()
                    {
                        Monto = new List<decimal>(),
                        Nombre = gast.TypeExpense,
                    };
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        gasto.Monto.Add(0);
                    }
                    for (int i = gast.Start; i <= gast.End; i++)
                    {
                        gasto.Monto[i] = Math.Round((i == 0 ? 0 : (decimal)(gast.Expense)), 2);
                    }
                    gastos.Add(gasto);
                }



            }
            return gastos;
        }
        public static List<ActivosGeneral> GetActivosGenerals(Project project)
        {
            int vidautil = 0;
            int periodo = (int)Enum.GetValues<Periodo>().Where(a => a.ToString() == project.Period).ToList()[0];
            List<ActivosGeneral> activos = new List<ActivosGeneral>();
            foreach (var depre in project.Assets)
            {
                vidautil = GetVidaUtil(depre.Name, periodo);
                if (depre.IsActive)
                {
                    ActivosGeneral activos1 = new ActivosGeneral() { Nombre = depre.Name };
                    activos1.Monto = new List<decimal>();
                    for (int i = 0; i <= vidautil - 1; i++)
                    {

                        if (depre.DepreciationRate == "LR")
                        {
                            activos1.Monto.Add(DLR(depre.Amount, vidautil, depre.AmountResidual)[i].DepreciaciónPorPeríodo);

                        }
                        else if (depre.DepreciationRate == "DSD")
                        {

                            activos1.Monto.Add(DDDS(depre.Amount, vidautil, depre.AmountResidual, 2)[i].DepreciaciónPorPeríodo);

                        }
                        else
                        {

                            activos1.Monto.Add(DSDA(depre.Amount, vidautil, depre.AmountResidual)[i].DepreciaciónPorPeríodo);

                        }
                    }
                    activos1.ValorResidual = depre.Amount - activos1.Monto.Sum();
                    activos.Add(activos1);
                }
                // TODO: Verificar desde Project.InvesmentArea recorrer con otro Foreach
                else if (depre.IsActive)
                {
                    ActivosGeneral activos1 = new ActivosGeneral() { Nombre = depre.Name };
                    activos1.Monto = new List<decimal>();
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        activos1.Monto.Add(i == 0 ? 0 : depre.Amount / project.Duration);
                    }
                    activos.Add(activos1);

                }
                else
                {
                    ActivosGeneral activos1 = new ActivosGeneral() { Nombre = depre.Name };
                    activos1.Monto = new List<decimal>();
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        activos1.Monto.Add(i == project.Duration ? depre.Amount : 0);
                    }

                    activos.Add(activos1);
                }

            }
            return activos;
        }
        public static List<IngresosGeneral> GetIngresosGenerals(Project project)
        {

            List<IngresosGeneral> ingresos = new List<IngresosGeneral>();

            foreach (var ing in project.ProjectEntries)
            {
                if (ing.TypeGrowth == TipoCrecimiento.Geometrico.ToString())
                {
                    IngresosGeneral ingresos1 = new IngresosGeneral()
                    {
                        Monto = new List<decimal>(),
                        Nombre = ing.EntryType
                    };
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        ingresos1.Monto.Add(0);
                    }
                    ing.Growth /= 100;
                    int j = 0;
                    for (int i = ing.Start; i <= ing.End; i++)
                    {
                        ingresos1.Monto[i] = Math.Round((ing.Entry * (decimal)Math.Pow((double)(1 + ing.Growth), j++)), 2);
                    }
                    ingresos.Add(ingresos1);
                }
                else if (ing.TypeGrowth == TipoCrecimiento.Aritmetico.ToString())
                {
                    IngresosGeneral ingresos1 = new IngresosGeneral()
                    {
                        Monto = new List<decimal>(),
                        Nombre = ing.EntryType
                    };
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        ingresos1.Monto.Add(0);
                    }
                    int j = 0;
                    for (int i = ing.Start; i <= ing.End; i++)
                    {
                        ingresos1.Monto[i] = Math.Round(((decimal)(ing.Entry + j++ * ing.Growth)), 2);
                    }
                    ingresos.Add(ingresos1);
                }
                else
                {
                    IngresosGeneral ingresos1 = new IngresosGeneral()
                    {
                        Monto = new List<decimal>(),
                        Nombre = ing.EntryType
                    };
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        ingresos1.Monto.Add(0);
                    }
                    for (int i = ing.Start; i <= ing.End; i++)
                    {
                        ingresos1.Monto[i] = Math.Round(((decimal)(ing.Entry)), 2);
                    }
                    ingresos.Add(ingresos1);
                }

            }
            return ingresos;
        }
        public static List<PrestamosGeneral> GetPrestamosGenerals(Project project)
        {
            List<decimal> prestamosN = new List<decimal>();
            List<decimal> Abono = new List<decimal>();
            List<PrestamosGeneral> prestamos = new List<PrestamosGeneral>();
            for (int i = 0; i <= project.Duration; i++)
            {
                prestamosN.Add(0);
                Abono.Add(0);
            }
            for (int i = 0; i < project.InvestmentEntities.Count; i++)
            {
                project.InvestmentEntities.ToList()[i].Contribution = project.InvestmentEntities.ToList()[i].IsPorcentage ?
                    (project.RecoveryCt + project.InvestmentArea.Sum(a => a.Amount)) *
                    (project.InvestmentEntities.ToList()[i].Contribution / 100) : project.InvestmentEntities.ToList()[i].Contribution;
            }
            foreach (var prest in project.InvestmentEntities)
            {
                if (prest.MoneyLoan)
                {
                    decimal tasa = (decimal)(prest.IsPorcentage ? prest.Rate : (prest.Rate / 100));
                    PrestamosGeneral prestamos1 = new PrestamosGeneral()
                    {
                        AbonoDeuda = new List<decimal>(),
                        Interes = new List<decimal>(),
                        Nombre = prest.Name
                    };
                    for (int ii = 0; ii <= project.Duration; ii++)
                    {
                        prestamos1.Interes.Add(0);
                        prestamos1.AbonoDeuda.Add(0);
                    }
                    for (int i = 0; i <= project.Duration; i++)
                    {/*
                        if (prest.TipoDeAmortizacion is TipoDeAmortizacion.AmortizacionNivelada)
                        {

                            prestamos1.Interes[i] = AmortizacionNivelada((decimal)prest.Contribution, prest.LoanTerm, tasa)[i].Interes;
                            prestamos1.AbonoDeuda[i] = AmortizacionNivelada((decimal)prest.Contribution, prest.LoanTerm, tasa)[i].AbonoDeuda;
                            prestamos1.SaldoInsoluto[i] = AmortizacionNivelada((decimal)prest.Contribution, prest.LoanTerm, tasa)[i].SaldoInsoluto;

                        }
                        else
                        {


                            prestamos1.Interes[i] = AmortizacionProporcional((decimal)prest.Contribution, prest.LoanTerm, tasa)[i].Interes;
                            prestamos1.AbonoDeuda[i] = AmortizacionProporcional((decimal)prest.Contribution, prest.LoanTerm, tasa)[i].AbonoDeuda;
                            prestamos1.SaldoInsoluto[i] = AmortizacionProporcional((decimal)prest.Contribution, prest.LoanTerm, tasa)[i].SaldoInsoluto;
                        }*/
                    }
                    prestamos.Add(prestamos1);
                }


            }
            return prestamos;
        }
        public static Totales Total(Project project)
        {

            List<decimal> CostosN = new List<decimal>();
            List<decimal> IngresosN = new List<decimal>();
            List<decimal> inversiones = new List<decimal>();
            for (int i = 0; i <= project.Duration; i++)
            {
                CostosN.Add(0);
            }
            foreach (var cost in project.ProjectCosts)
            {

                if (cost.TypeGrowth == TipoCrecimiento.Geometrico.ToString())
                {
                    cost.Growth /= 100;
                    int j = 0;
                    for (int i = cost.Start; i <= cost.End; i++)
                    {
                        CostosN[i] += (cost.Cost * (decimal)Math.Pow((double)(1 + cost.Growth), j++));
                    }
                }
                else if (cost.TypeGrowth == TipoCrecimiento.Aritmetico.ToString())
                {
                    int j = 0;
                    for (int i = cost.Start; i <= cost.End; i++)
                    {
                        CostosN[i] += ((decimal)(cost.Cost + j++ * cost.Growth));

                    }
                }
                else
                {
                    for (int i = cost.Start; i <= cost.End; i++)
                    {
                        CostosN[i] += ((decimal)(cost.Cost));
                    }
                }

            }
            for (int i = 0; i <= project.Duration; i++)
            {
                IngresosN.Add(0);
            }
            foreach (var ing in project.ProjectEntries)
            {

                if (ing.TypeGrowth == TipoCrecimiento.Geometrico.ToString())
                {
                    ing.Growth /= 100;
                    int j = 0;
                    for (int i = ing.Start; i <= ing.End; i++)
                    {
                        IngresosN[i] += (ing.Entry * (decimal)Math.Pow((double)(1 + ing.Growth), j++));
                    }
                }
                else if (ing.TypeGrowth == TipoCrecimiento.Aritmetico.ToString())
                {
                    int j = 0;
                    for (int i = ing.Start; i <= ing.End; i++)
                    {
                        IngresosN[i] += IngresosN[i] += ((decimal)(ing.Entry + j++ * ing.Growth));
                    }
                }
                else
                {
                    for (int i = ing.Start; i <= ing.End; i++)
                    {
                        IngresosN[i] += ((decimal)(ing.Entry));
                    }
                }

            }
            for (int i = 0; i <= project.Duration; i++)
            {
                inversiones.Add(0);
            }

            for (int i = 0; i <= project.Duration; i++)
            {
                foreach (var inv in project.InvestmentArea)
                {
                    if (i == inv.Start)
                    {
                        inversiones[i] += inv.Amount;
                    }
                }
            }
            Totales totales = new Totales()
            {
                NombreProjecto = project.Name,
                TotalCostos = CostosN.Sum(),
                TotalIngresos = IngresosN.Sum(),
                TotalInversiones = inversiones.Sum(),
                CantidadCostos = CostosN.Count - 1,
                CantidadIngresos = IngresosN.Count - 1,
                CantidadInversiones = inversiones.Count - 1
            };
            return totales;
        }
    }
    public class Convertir<T>
    {

        public DataTable ConvertirListaToDataTable(IList data)
        {

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties) table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties) row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
    public class financiamiento
    {
        public string Nombre { get; set; }
        public decimal Aportacion { get; set; }
    }
    public class PastelData
    {
        public decimal Valor { get; set; }
        public string Nombres { get; set; }
    }
}
