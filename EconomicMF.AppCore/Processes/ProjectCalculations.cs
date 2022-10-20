using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.DTO;
using EconomicMF.Domain.Entities.FlowTool;
using EconomicMF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using EconomicMF.Domain.Entities.FlowTool.ClasesFlujo;
using System.Data;
using System.ComponentModel;
using System.Collections;
using EconomicMF.Domain.Enums.Others;
using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Services;
using EconomicMF.Services.Processes.Intereses;

namespace EconomicMF.AppCore.Processes
{
    public static class ProjectCalculations
    {
        public static Project GetBestProject(List<Project> projects, int IdSolution)
        {
            try
            {
                if (projects == null || projects.Count == 0)
                {
                    throw new ArgumentNullException("se encontró un problema con los proyectos");
                }
                if (IdSolution < 0)
                {
                    throw new ArgumentNullException("se encontró un problema con el id de la solucion");
                }
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
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable Financiamientos(Project p)
        {
            try
            {
                if (p == null)
                {
                    throw new ArgumentException("Se encontró un problema con el proyecto");
                }
                List<financiamiento> financials = new List<financiamiento>();
                decimal inv = 100;
                foreach (var item in p.InvestmentEntities)
                {
                    inv -= (decimal)item.Contribution;
                    financials.Add(new financiamiento() { Nombre = item.Name, Aportacion = (decimal)item.Contribution / 100 });
                }
                financials.Add(new financiamiento() { Nombre = "InversionistaProyecto", Aportacion = inv / 100 });
                Convertir<financiamiento> convertir = new Convertir<financiamiento>();
                return convertir.ConvertirListaToDataTable(financials);

            }
            catch (Exception)
            {
                throw;
            }

        }
        public static DataTable DatosPastel(Project p)
        {
            try
            {
                if (p == null)
                {
                    throw new ArgumentException("Se encontró un problema con el proyecto");
                }
                List<PastelData> datas = new List<PastelData>();
                decimal denom = GastosN(p).Sum(x => x.Gasto) + costosN(p).Sum(x => x.costo) + PrestamosN(p).Sum(x => x.Monto) + ActivosN(p).Sum(x => x.Monto);
                datas.Add(new PastelData() { Nombres = "Gastos", Valor = GastosN(p).Sum(x => x.Gasto) / denom });
                datas.Add(new PastelData() { Nombres = "Costos", Valor = costosN(p).Sum(x => x.costo) / denom });
                datas.Add(new PastelData() { Nombres = "Amortización", Valor = PrestamosN(p).Sum(x => x.AbonoDeuda) / denom });
                datas.Add(new PastelData() { Nombres = "Depreciación", Valor = ActivosN(p).Sum(x => x.Monto) / denom });
                Convertir<PastelData> convertir = new Convertir<PastelData>();
                return convertir.ConvertirListaToDataTable(datas);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static DataTable DatosProjecto(Project p, bool mejor)
        {
            try
            {
                if (p == null)
                {
                    throw new ArgumentException("Se encontró un problema con el proyecto");
                }
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

                data["TMAR"] = p.WithFinancing ? Math.Round(TMAR(p), 2) : Math.Round(p.TMAR, 2);
                /*decimal total = GastosN(p).Sum(i => i.Gasto) + ingresosN(p).Sum(i => i.Monto) + ActivosN(p).Sum(i => i.Monto) + costosN(p).Sum(i => i.costo)
                    + PrestamosN(p).Sum(i => i.Monto);*/
                data["VPN"] = Math.Round(VPN(FNE(p), p.WithFinancing ? TMAR(p) : p.TMAR), 2);
                string conclusion = "";
                if (VPN(FNE(p), p.WithFinancing ? TMAR(p) : p.TMAR) > 0 && (TIR(FNE(p)) > (p.WithFinancing ? TMAR(p) : p.TMAR)))
                {
                    conclusion = "Al ser el valor presente neto (VPN) mayor que 0, y la tasa interna de retorno (TIR) mayor que la TMAR se considera que el proyecto es rentable";
                }
                else if (VPN(FNE(p), p.WithFinancing ? TMAR(p) : p.TMAR) < 0 && (TIR(FNE(p)) < (p.WithFinancing ? TMAR(p) : p.TMAR)))
                {
                    conclusion = "Al ser el valor presente neto (VPN) menor que 0, y la tasa interna de retorno (TIR) menor que la TMAR se considera que el proyecto no es rentable";
                }
                else if ((VPN(FNE(p), p.WithFinancing ? TMAR(p) : p.TMAR) < 0))
                {
                    conclusion = "Al ser el valor presente neto (VPN) menor que 0 se considera que el proyecto no es rentable";
                }
                else if ((TIR(FNE(p)) < (p.WithFinancing ? TMAR(p) : p.TMAR)))
                {
                    conclusion = "Al ser la tasa interna de retorno (TIR) menor que la TMAR se considera que el proyecto no es rentable";
                }
                else if (VPN(FNE(p), p.WithFinancing ? TMAR(p) : p.TMAR) > 0)
                {
                    conclusion = "Al ser el valor presente neto (VPN) mayor que 0 se considera que el proyecto es rentable";
                }
                else if ((TIR(FNE(p)) > (p.WithFinancing ? TMAR(p) : p.TMAR)))
                {
                    conclusion = "Al ser la tasa interna de retorno (TIR) mayor que la TMAR se considera que el proyecto es rentable";
                }
                decimal cien = 100;
                decimal s = GastosN(p).Sum(i => i.Gasto);
                decimal s1 = costosN(p).Sum(i => i.costo);
                decimal s2 = ActivosN(p).Sum(i => i.Monto);
                data["Gastos"] = conclusion;// / total * cien) ;
                data["Costos"] = costosN(p).Sum(i => i.costo);// / total * cien);
                data["Amortizacion"] = s2;// / total * cien);
                data["Nombre"] = p.Name;
                data["Financiamiento"] = p.InvestmentEntities.Count == 1 ? "Sin financiamineto" : "Con financiamiento";
                data["Periodo"] = p.Duration;
                data["Tipo"] = p.Period;
                data["Descripcion"] = p.Description;
                data["NombreInv"] = Math.Round((GastosN(p).Sum(i => i.Gasto) + costosN(p).Sum(i => i.costo) + ActivosN(p).Sum(i => i.Monto) + PrestamosN(p).Sum(x => x.AbonoDeuda)), 2);
                data["Foto"] = Math.Round(ingresosN(p).Sum(x => x.Monto), 2);
                dt.Rows.Add(data);
                return dt;

            }
            catch (Exception)
            {
                throw;
            }

        }
        public static DataTable FlujosReport(Project p)
        {
            try
            {

                if (p == null)
                {
                    throw new ArgumentException("Se encontró un problema con el proyecto");
                }
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
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable AllFNE(Project p)
        {
            /*try
            {*/
            FlujoGeneral flujo = GetGeneral(p);
            if (p == null)
            {
                throw new ArgumentException("Se encontró un problema con el proyecto");
            }
            int a = 0;
            DataTable dt = new DataTable();
            List<Flujo> flujos = FNE(p);
            //Convertir<Flujo> convertir = new Convertir<Flujo>();
            dt = GetDataDTO(p);
            DataRow data = dt.NewRow();
            data["Conceptos:"] = "Utilidad antes de IR";
            for (int i = 0; i < flujos.Count; i++)
            {

                data[i.ToString()] = flujos[i].Utilidad_antes_de_IR;
            }
            dt.Rows.Add(data);
            DataRow data1 = dt.NewRow();
            data1["Conceptos:"] = "IR";
            for (int i = 0; i < flujos.Count; i++)
            {

                data1[i.ToString()] = flujos[i].IR;
            }
            dt.Rows.Add(data1);
            DataRow data2 = dt.NewRow();
            data2["Conceptos:"] = "Utilidades despues de IR";
            for (int i = 0; i < flujos.Count; i++)
            {

                data2[i.ToString()] = flujos[i].Utilidad_después_de_IR;
            }
            dt.Rows.Add(data2);
            foreach (var item in flujo.activosGenerals)
            {
                DataRow dr = dt.NewRow();
                if (item.Nombre == "Terreno")
                {

                }
                else if (item.Nombre.Contains("Diferida") || item.Nombre.Contains("Diferido"))
                {
                    dr["Conceptos:"] = item.Nombre;
                    for (int i = 0; i < item.Monto.Count; i++)
                    {
                        dr[i.ToString()] = item.Monto[i];
                    }
                    dt.Rows.Add(dr);
                }
                else
                {
                    dr["Conceptos:"] = "Depreciacion de " + item.Nombre;
                    for (int i = 0; i < item.Monto.Count; i++)
                    {
                        dr[i.ToString()] = item.Monto[i];
                    }
                    dt.Rows.Add(dr);
                }

            }
            if (p.WithFinancing)
            {
                DataRow data3 = dt.NewRow();
                data3["Conceptos:"] = "Amortización";
                for (int i = 0; i < flujos.Count; i++)
                {

                    data3[i.ToString()] = flujos[i].Amortización_;
                }
                dt.Rows.Add(data3);
            }
            DataRow data4 = dt.NewRow();
            data4["Conceptos:"] = "Valor residual";
            for (int i = 0; i < flujos.Count; i++)
            {

                data4[i.ToString()] = flujos[i].ValorResidual;
            }
            dt.Rows.Add(data4);
            DataRow data5 = dt.NewRow();
            data5["Conceptos:"] = "Recuperación de capital de trabajo";
            for (int i = 0; i < flujos.Count; i++)
            {

                data5[i.ToString()] = flujos[i].Recuperación_de_capital_de_Trabajo;
            }
            dt.Rows.Add(data5);
            if (p.WithFinancing)
            {

                foreach (var item in p.InvestmentEntities)
                {
                    DataRow dr = dt.NewRow();
                    decimal Total = p.Assets.Sum(x => x.Amount) + p.InvestmentArea.Sum(x => x.RecoveryCt) + p.InvestmentArea.Sum(x => x.Amount);
                    dr["Conceptos:"] = "Prestamos de " + item.Name;
                    for (int i = 0; i < p.Duration; i++)
                    {
                        dr[i.ToString()] = Math.Round(i == 0 ? (item.Contribution / 100) * Total : 0, 2);
                    }
                    dt.Rows.Add(dr);
                }
                data = dt.NewRow();
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
            }
            DataRow data7 = dt.NewRow();
            data7["Conceptos:"] = "Inverion Total";
            for (int i = 0; i < flujos.Count; i++)
            {

                data7[i.ToString()] = flujos[i].Inversion;
            }
            dt.Rows.Add(data7);
            data = dt.NewRow();
            data["Conceptos:"] = "FNE";
            for (int i = 0; i < flujos.Count; i++)
            {

                data[i.ToString()] = flujos[i].FNE;
            }
            dt.Rows.Add(data);
            return dt;
            /*}
            catch (Exception)
            {
                throw;
            }*/

        }
        public static decimal VPN(List<Flujo> flujosnetos, decimal tasa)
        {
            try
            {
                if (flujosnetos == null || flujosnetos.Count == 0)
                {
                    throw new ArgumentException("Se encontró un problema con los flujos netos");
                }
                tasa /= 100;
                List<double> fne = new List<double>();

                foreach (var item in flujosnetos)
                {
                    fne.Add((double)item.FNE);
                }
                List<double> doubles = new List<double>();
                for (int i = 1; i < fne.Count; i++)
                {
                    doubles.Add(fne[i]);
                }
                var pasar = doubles.ToArray();
                return (decimal)(Microsoft.VisualBasic.Financial.NPV((double)tasa, ref pasar) + fne[0]);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static decimal TMAR(Project project)
        {
            try
            {
                if (project == null)
                {
                    throw new ArgumentException("Se encontró un problema con el proyecto");
                }
                List<decimal> tasas = new List<decimal>();
                decimal tp = 100;
                foreach (var inv in project.InvestmentEntities)
                {
                    tp -= (decimal)inv.Contribution;
                }
                foreach (var inv in project.InvestmentEntities)
                {
                    tasas.Add((decimal)((inv.Contribution / 100) * (inv.Rate / 100)));

                }
                tasas.Add((project.TMAR / 100) * (tp / 100));
                return Math.Round(tasas.Sum() * 100, 2);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static decimal TIR(List<Flujo> flujosnetos, decimal adivinar = (decimal)10)
        {
            try
            {
                if (flujosnetos == null || flujosnetos.Count == 0)
                {
                    throw new ArgumentException("Se encontró un problema con los flujos netos");
                }
                adivinar /= 100;
                List<double> fne = new List<double>();

                foreach (var item in flujosnetos)
                {
                    fne.Add((double)item.FNE);
                }

                var doubles = fne.ToArray();
                return Math.Round((decimal)(Microsoft.VisualBasic.Financial.IRR(ref doubles, 0.1) * 100), 2);
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static decimal CAUE(List<Flujo> flujosnetos, decimal TMAR)
        {
            try
            {
                if (flujosnetos == null || flujosnetos.Count == 0)
                {
                    throw new ArgumentException("Se encontró un problema con los flujos netos");
                }
                TMAR /= 100;
                List<double> fne = new List<double>(flujosnetos.Count);
                for (int i = 0; i <= fne.Count; i++)
                {
                    fne[i] = -1 * (double)(flujosnetos[i].FNE - flujosnetos[i].IngresosNetos) / Math.Pow(1 + (double)TMAR, i);
                }

                return (decimal)fne.Sum() * (TMAR * (decimal)Math.Pow(1 + (double)TMAR, fne.Count - 1)) /
                    ((decimal)Math.Pow(1 + (double)TMAR, fne.Count - 1) - 1);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Depreciación
        public static List<DLR> DLR(decimal Costo, int N, decimal VR = 0)
        {
            try
            {
                if (Costo == 0 || N <= 0 || VR < 0)
                {
                    throw new ArgumentException("Se encontró un problema con los datos");
                }
                decimal depreciacion = (Costo - VR) / N;
                List<DLR> dLRs = new List<DLR>();
                for (int i = 0; i <= N; i++)
                {

                    DLR dLR = new DLR()
                    {
                        Período = i,
                        DepreciaciónPorPeríodo = i == 0 ? 0 : Math.Round(depreciacion, 2),
                        DepreciaciónAcumulada = i == 0 ? 0 : Math.Round(depreciacion * i, 2),
                        valorLibros = Math.Round(i == 0 ? Costo : Costo - depreciacion * i, 2),
                    };
                    dLRs.Add(dLR);
                }
                return dLRs;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Depreciación
        public static List<DSDA> DSDA(decimal Costo, int N, decimal VR = 0)
        {
            try
            {
                if (Costo == 0 || N <= 0 || VR < 0)
                {
                    throw new ArgumentException("Se encontró un problema con los datos");
                }
                List<DSDA> dSDAs = new List<DSDA>();
                decimal cant = Costo - VR;
                decimal valor = Costo;
                for (int i = 0; i <= N; i++)
                {
                    decimal depreciacion = i == 0 ? 0 : (decimal)Microsoft.VisualBasic.Financial.SYD((double)Costo, (double)VR, N, i);
                    valor -= depreciacion;
                    DSDA dSDA = new DSDA()
                    {
                        Período = i,
                        Fraccion = i == 0 ? "0" : ((2 * ((double)N - i + 1)).ToString() + "/" + ((double)N * ((double)N + 1)).ToString()).ToString(),
                        CantidadDepreciableTotal = i == 0 ? 0 : Math.Round(cant, 2),
                        DepreciaciónPorPeríodo = i == 0 ? 0 : Math.Round(depreciacion, 2),
                        ValorLibro = Math.Round(i == 0 ? Costo : valor, 2)

                    };
                    dSDAs.Add(dSDA);
                }
                return dSDAs;
            }
            catch (Exception)
            {
                throw;
            }

        }
        //Microsoft.VisualBasic.Financial.
        //Depreciación
        public static List<DDDS> DDDS(decimal Costo, int N, decimal VR = 0, decimal Factor1 = 2)
        {
            try
            {
                if (Costo == 0 || N <= 0 || VR < 0)
                {
                    throw new ArgumentException("Se encontró un problema con los datos");
                }
                int n = N;
                //decimal depreciacion1 = (decimal)Financial.Ddb((double)Costo, (double)VR, N, 8, Math.Round((double)Factor1));
                decimal cost = Costo;
                decimal depre = 0;
                List<DDDS> dDDs = new List<DDDS>();
                for (int i = 0; i <= N; i++)
                {
                    decimal depreciacion = i == 0 ? 0 : (decimal)Microsoft.VisualBasic.Financial.DDB((double)cost, (double)VR, n, i, Math.Round((double)Factor1));
                    depre += depreciacion;
                    //depreciacion /= i == 0 ? 1 : i;
                    Costo -= (decimal)depreciacion;
                    if (i == N && Costo != VR)
                    {
                        depre -= depreciacion;
                        depre = cost - depre;
                        depre = cost - VR;
                        Costo = VR;
                    }
                    DDDS dDD = new DDDS()
                    {
                        Período = i,
                        Tasa = Math.Round(((2 / (double)N) * 100), 2).ToString() + "%",
                        DepreciaciónPorPeríodo = i == 0 ? 0 : Math.Round(depre, 2),
                        ValorLibro = Math.Round(Costo, 2)
                    };
                    dDDs.Add(dDD);

                }
                return dDDs;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static List<List<Amortizacion>> Amortizaciones(Project p)
        {
            try
            {
                if (p == null)
                {
                    throw new ArgumentException("Se encontró un problema con el proyecto");
                }
                List<List<Amortizacion>> deudas = new List<List<Amortizacion>>();
                decimal Total = p.Assets.Sum(x => x.Amount) + p.InvestmentArea.Sum(x => x.RecoveryCt) + p.InvestmentArea.Sum(x => x.Amount);
                foreach (var item in p.InvestmentEntities)
                {
                    if (item.TipoDeAmortización == TipoDeAmortizacion.AmortizacionNivelada.ToString())
                    {
                        deudas.Add(AmortizacionNivelada((decimal)((item.Contribution / 100) * Total), p.Duration, (decimal)TMAR(p)));
                    }
                    else
                    {
                        deudas.Add(AmortizacionProporcional((decimal)((item.Contribution / 100) * Total), p.Duration, (decimal)TMAR(p)));
                    }
                }
                return deudas;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static List<List<Amortizacion>> Amortizaciones(List<Prestamo> p)
        {
            try
            {
                if (p == null)
                {
                    throw new ArgumentException("Se encontró un problema con el proyecto");
                }
                List<List<Amortizacion>> deudas = new List<List<Amortizacion>>();

                foreach (var item in p)
                {
                    if (item.TipoDeAmortizacion.Equals(TipoDeAmortizacion.AmortizacionNivelada.ToString()))
                    {
                        deudas.Add(AmortizacionNivelada(item.Monto, item.Año, (decimal)item.Interes));
                    }
                    else
                    {
                        deudas.Add(AmortizacionProporcional(item.Monto, item.Año, (decimal)item.Interes));
                    }
                }
                return deudas;
            }
            catch (Exception)
            {
                throw;
            }

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
                    decimal crecimiento = cost.Growth / 100;
                    int j = 0;
                    for (int i = cost.Start; i <= cost.End; i++)
                    {
                        CostosN[i].costo += (cost.Cost * (decimal)Math.Pow((double)(1 + crecimiento), j++));
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
                    decimal crecimiento = gasto.Growth / 100;
                    int j = 0;
                    for (int i = gasto.Start; i <= gasto.End; i++)
                    {
                        gastosN[i].Gasto += (gasto.Expense * (decimal)Math.Pow((double)(1 + crecimiento), j++));
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
            List<decimal> saldoInsoluto = new List<decimal>();
            List<Prestamos> prestamos = new List<Prestamos>();
            for (int i = 0; i <= project.Duration; i++)
            {
                prestamosN.Add(0);
                Abono.Add(0);
                saldoInsoluto.Add(0);
            }
            foreach (var prest in project.InvestmentEntities)
            {
                decimal contribuccion = ((project.Assets.Sum(a => a.Amount) + project.InvestmentArea.Sum(a => a.Amount) + project.InvestmentArea.Sum(a => a.RecoveryCt)) *
                    (prest.Contribution / 100));
                if (prest.MoneyLoan)
                {
                    decimal tasa = prest.Rate;

                    for (int i = 0; i <= project.Duration; i++)
                    {
                        if (prest.TipoDeAmortización == TipoDeAmortizacion.AmortizacionNivelada.ToString())
                        {
                            //////revisar la tas del inversionista
                            prestamosN[i] += AmortizacionNivelada((decimal)contribuccion, prest.LoanTerm, tasa)[i].Interes;
                            Abono[i] += AmortizacionNivelada((decimal)contribuccion, prest.LoanTerm, tasa)[i].AbonoDeuda;
                            saldoInsoluto[i] += AmortizacionNivelada((decimal)contribuccion, prest.LoanTerm, tasa)[i].SaldoInsoluto;

                        }
                        else
                        {

                            prestamosN[i] += AmortizacionProporcional((decimal)contribuccion, prest.LoanTerm, tasa)[i].Interes;
                            Abono[i] += AmortizacionProporcional((decimal)contribuccion, prest.LoanTerm, tasa)[i].AbonoDeuda;
                            saldoInsoluto[i] += AmortizacionProporcional((decimal)contribuccion, prest.LoanTerm, tasa)[i].SaldoInsoluto;
                        }
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
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Ascensores);
                    break;
                case "Edificios_Industriales":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Edificios_Industriales);
                    break;
                case "Edificios_Comerciales":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Edificios_Comerciales);
                    break;
                case "Residencia_Del_Propietario":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Residencia_Del_Propietario);
                    break;
                case "Edificios_De_Alquiler":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Edificios_De_Alquiler);
                    break;
                case "Instalaciones_fijas_en_explotacion_agropecuaria":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Instalaciones_fijas_en_explotacion_agropecuaria);
                    break;
                case "Colectivo_De_Carga":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Colectivo_De_Carga);
                    break;
                case "Vehiculo_De_Empresas_de_Alquiler":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Vehiculo_De_Empresas_de_Alquiler);
                    break;
                case "Otros_Equipos_de_Transporte":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Otros_Equipos_de_Transporte);
                    break;
                case "Maquinaria_fija_en_bien_inmovil":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Maquinaria_fija_en_bien_inmovil);
                    break;
                case "Maquinaria_no_adherida_permanentemente":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Maquinaria_no_adherida_permanentemente);
                    break;
                case "Otras_Maquinarias_y_Equipo":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Otras_Maquinarias_y_Equipo);
                    break;
                case "Equipos_de_Empresas_Agroindustriales":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Equipos_de_Empresas_Agroindustriales);
                    break;
                case "Equipos_Agricolas":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Equipos_Agricolas);
                    break;
                case "Mobilario_y_Equipo_de_Oficina":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Mobilario_y_Equipo_de_Oficina);
                    break;
                case "Equipos_de_Comunicacion":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Equipos_de_Comunicacion);
                    break;
                case "Equipos_de_Computacion":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Equipos_de_Computacion);
                    break;
                case "Equipos_para_Medio_de_comunicacion":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Equipos_para_Medio_de_comunicacion);
                    break;
                case "Elevadores":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Elevadores);
                    break;
                case "Unidad_de_Aire_Acondicionado":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Unidad_de_Aire_Acondicionado);
                    break;
                case "Otros_bienes_muebles":
                    vidautil = CalculusOnMemory.GetTerms(VidaUtilActivos.Otros_bienes_muebles);
                    break;
            }
            return vidautil * periodo;
        }
        public static decimal GetValorResidual(Project project)
        {
            decimal valorResidual = 0;
            foreach (var a in project.Assets)
            {
                valorResidual = a.Name == VidaUtilActivos.Terreno.ToString() ? a.Amount : 0;
            }
            return project.Assets.Sum(x => x.AmountResidual) + valorResidual;
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
            var list1 = new List<decimal>();
            foreach (var depre in project.Assets)
            {
                vidautil = GetVidaUtil(depre.Name, periodo);
                if (depre.IsDepreciable)
                {
                    for (int i = 0; i <= (vidautil>project.Duration?project.Duration:vidautil); i++)
                    {
                        if (depre.DepreciationRate == Depreciacion.DLR.ToString())
                        {
                            activosN[i].Monto += DLR(depre.Amount, vidautil, depre.AmountResidual)[i].DepreciaciónPorPeríodo;
                            int j = 0;
                        }
                        if (depre.DepreciationRate == Depreciacion.DDDS.ToString())
                        {
                            activosN[i].Monto += DDDS(depre.Amount, vidautil, depre.AmountResidual)[i].DepreciaciónPorPeríodo;
                        }
                        if (depre.DepreciationRate == Depreciacion.DSDA.ToString())
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
                    decimal crecimiento = ing.Growth / 100;
                    int j = 0;
                    for (int i = ing.Start; i <= ing.End; i++)
                    {
                        IngresosN[i].Monto += (ing.Entry * (decimal)Math.Pow((double)(1 + crecimiento), j++));
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
            List<decimal> prestamosTotales = new List<decimal>();
            for (int i = 0; i <= project.Duration; i++)
            {
                prestamosTotales.Add(0);
                Diferido.Add(0);
            }
            foreach (var d in project.InvestmentArea)
            {
                if ((bool)d.IsDiferida)
                {
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        Diferido[i] += i != 0 ? d.Amount / project.Duration : 0;
                    }
                }
            }
            var terreno = project.Assets.Where(x => x.Name == VidaUtilActivos.Terreno.ToString());
            foreach (var item in project.InvestmentEntities)
            {
                decimal Total = project.Assets.Sum(x => x.Amount) + project.InvestmentArea.Sum(x => x.RecoveryCt) + project.InvestmentArea.Sum(x => x.Amount);
                for (int i = 0; i < project.Duration; i++)
                {
                    prestamosTotales[i] = i == 0 ? (item.Contribution / 100) * Total : 0;
                    int j = 0;
                }

            }
            List<Ingresos> IngresosN = ingresosN(project);
            for (int i = 0; i <= project.Duration; i++)
            {
                int a = i;
                Flujo flujoefectivo = new Flujo()
                {
                    Concepto = i,
                    Inversion = i == 0 ? decimal.Round(project.InvestmentArea.Sum(a => a.Amount) + project.InvestmentArea.Sum(a => a.RecoveryCt) + project.Assets.Sum(x => x.Amount), 2) : 0,
                    ValorResidual = i == project.Duration ? GetValorResidual(project) : 0M,
                };

                flujoefectivo.IngresosNetos = decimal.Round(IngresosN[i].Monto, 2);
                //flujoefectivo.PrestamosNetos = project.WithFinancing ? decimal.Round(PrestamosNetos[i], 2) : 0;
                flujoefectivo.InterésesNetos = project.WithFinancing ? decimal.Round(prestamosN[i].Monto, 2) : 0;
                flujoefectivo.Abono_a_la_deuda = project.WithFinancing ? (project.WithFinancing ? decimal.Round(prestamosN[i].AbonoDeuda, 2) : 0) : 0;
                flujoefectivo.CostosNetos = decimal.Round(CostosN[i].costo, 2);
                flujoefectivo.GastosNetos = decimal.Round(gastosN[i].Gasto, 2);

                flujoefectivo.Amortización = decimal.Round(Diferido[i], 2);
                flujoefectivo.Amortización_ = decimal.Round(Diferido[i], 2);
                flujoefectivo.Depreciación = decimal.Round(activosN[i].Monto, 2);
                flujoefectivo.Depreciación_ = decimal.Round(activosN[i].Monto, 2);
                decimal total = IngresosN[i].Monto - CostosN[i].costo - gastosN[i].Gasto - (project.WithFinancing ? prestamosN[i].Monto : 0) - activosN[i].Monto - Diferido[i];
                flujoefectivo.Utilidad_antes_de_IR = decimal.Round(total, 2);
                flujoefectivo.IR = decimal.Round(total * (decimal)0.3, 2);
                flujoefectivo.Recuperación_de_capital_de_Trabajo = i == project.Duration ? project.InvestmentArea.Sum(a => a.RecoveryCt) : 0;
                flujoefectivo.Utilidad_después_de_IR = decimal.Round(total - (total * (decimal)0.3), 2);
                //decimal ver = prestamosTotales[i] - flujoefectivo.Inversion;
                decimal neto = (decimal)(flujoefectivo.Utilidad_después_de_IR + activosN[i].Monto + (project.WithFinancing ? prestamosTotales[i] : 0)
                    + (i == project.Duration ? project.InvestmentArea.Sum(e => e.RecoveryCt) : 0) - (project.WithFinancing ? prestamosN[i].AbonoDeuda : 0) - flujoefectivo.Inversion + Diferido[i] + (i == project.Duration ? (terreno != null ? terreno.Sum(x => x.Amount) : 0) : 0));
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
        public static DataTable GetDataDTO(Project project)
        {
            FlujoGeneral flujo = GetGeneral(project);
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
            if (project.WithFinancing)
            {
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
            }
            foreach (var item in flujo.activosGenerals)
            {
                DataRow dr = data.NewRow();
                if (item.Nombre == VidaUtilActivos.Terreno.ToString())
                {
                    dr["Conceptos:"] = item.Nombre;

                }
                else if (item.Nombre.Contains("Diferida") || item.Nombre.Contains("Diferido"))
                {
                    dr["Conceptos:"] = "Amortizacion de activo diferido";
                    for (int i = 0; i < item.Monto.Count; i++)
                    {
                        dr[i.ToString()] = item.Monto[i];
                    }
                    data.Rows.Add(dr);
                }
                else
                {
                    dr["Conceptos:"] = "Depreciacion de " + item.Nombre;
                    for (int i = 0; i < item.Monto.Count; i++)
                    {
                        dr[i.ToString()] = item.Monto[i];
                    }
                    data.Rows.Add(dr);
                }

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
                    decimal crecimiento = cost.Growth / 100;
                    int j = 0;
                    for (int i = cost.Start; i <= cost.End; i++)
                    {
                        costo.Monto[i] = Math.Round((cost.Cost * (decimal)Math.Pow((double)(1 + crecimiento), j++)), 2);
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
                    decimal crecimiento = gast.Growth / 100;
                    int j = 0;
                    for (int i = gast.Start; i <= gast.End; i++)
                    {
                        gasto.Monto[i] = Math.Round((i == 0 ? 0 : gast.Expense * (decimal)Math.Pow((double)(1 + crecimiento), j++)), 2);
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
                if (depre.IsDepreciable)
                {
                    ActivosGeneral activos1 = new ActivosGeneral() { Nombre = depre.Name };
                    activos1.Monto = new List<decimal>();
                    for (int i = 0; i <= (vidautil > project.Duration ? project.Duration : vidautil); i++)
                    {

                        if (depre.DepreciationRate == Depreciacion.DLR.ToString())
                        {
                            activos1.Monto.Add(DLR(depre.Amount, vidautil, depre.AmountResidual)[i].DepreciaciónPorPeríodo);

                        }
                        else if (depre.DepreciationRate == Depreciacion.DDDS.ToString())
                        {

                            activos1.Monto.Add(DDDS(depre.Amount, vidautil, depre.AmountResidual)[i].DepreciaciónPorPeríodo);

                        }
                        else
                        {

                            activos1.Monto.Add(DSDA(depre.Amount, vidautil, depre.AmountResidual)[i].DepreciaciónPorPeríodo);

                        }
                    }
                    activos1.ValorResidual = depre.Amount - activos1.Monto.Sum();
                    activos.Add(activos1);
                }
                else if (depre.Name == VidaUtilActivos.Terreno.ToString())
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
            foreach (var depre in project.InvestmentArea)
            {
                if ((bool)depre.IsDiferida)
                {
                    ActivosGeneral activos1 = new ActivosGeneral() { Nombre = "(Diferido)" + depre.Name };
                    activos1.Monto = new List<decimal>();
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        activos1.Monto.Add(i == 0 ? 0 : depre.Amount / project.Duration);
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
                    decimal crecimiento = ing.Growth / 100;
                    int j = 0;
                    for (int i = ing.Start; i <= ing.End; i++)
                    {
                        ingresos1.Monto[i] = Math.Round((ing.Entry * (decimal)Math.Pow((double)(1 + crecimiento), j++)), 2);
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
            List<PrestamosGeneral> prestamos = new List<PrestamosGeneral>();
            foreach (var prest in project.InvestmentEntities)
            {
                decimal contribuccion = ((project.Assets.Sum(a => a.Amount) + project.InvestmentArea.Sum(a => a.Amount) + project.InvestmentArea.Sum(a => a.RecoveryCt)) *
                    (prest.Contribution / 100));
                if (prest.MoneyLoan)
                {
                    decimal tasa = prest.Rate;
                    PrestamosGeneral prestamos1 = new PrestamosGeneral()
                    {
                        AbonoDeuda = new List<decimal>(),
                        Interes = new List<decimal>(),
                        Nombre = prest.Name,
                        SaldoInsoluto = new List<decimal>()
                    };
                    for (int ii = 0; ii <= project.Duration; ii++)
                    {
                        prestamos1.Interes.Add(0);
                        prestamos1.AbonoDeuda.Add(0);
                        prestamos1.SaldoInsoluto.Add(0);
                    }
                    for (int i = 0; i <= project.Duration; i++)
                    {
                        if (prest.TipoDeAmortización == TipoDeAmortizacion.AmortizacionNivelada.ToString())
                        {

                            prestamos1.Interes[i] = AmortizacionNivelada((decimal)contribuccion, prest.LoanTerm, tasa)[i].Interes;
                            prestamos1.AbonoDeuda[i] = AmortizacionNivelada((decimal)contribuccion, prest.LoanTerm, tasa)[i].AbonoDeuda;
                            prestamos1.SaldoInsoluto[i] = AmortizacionNivelada((decimal)contribuccion, prest.LoanTerm, tasa)[i].SaldoInsoluto;

                        }
                        else
                        {

                            prestamos1.Interes[i] = AmortizacionProporcional((decimal)contribuccion, prest.LoanTerm, tasa)[i].Interes;
                            prestamos1.AbonoDeuda[i] = AmortizacionProporcional((decimal)contribuccion, prest.LoanTerm, tasa)[i].AbonoDeuda;
                            prestamos1.SaldoInsoluto[i] = AmortizacionProporcional((decimal)contribuccion, prest.LoanTerm, tasa)[i].SaldoInsoluto;
                        }
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
        #region Totales

        public static List<PastelData> TotalIndividual(List<ProjectEntry> projectEntries)
        {
            List<PastelData> total = new List<PastelData>();
            foreach (var ingreso in projectEntries)
            {
                int n = ingreso.End - ingreso.Start;
                PastelData pastel = CrearPastel(ingreso.TypeGrowth, n, ingreso.EntryType, ingreso.Entry, ingreso.Growth);
                total.Add(pastel);
            }
            return total;
        }

        public static List<PastelData> TotalIndividual(List<ProjectCost> projectcost)
        {
            List<PastelData> total = new List<PastelData>();
            foreach (var cost in projectcost)
            {
                int n = cost.End - cost.Start;
                PastelData pastel = CrearPastel(cost.TypeGrowth, n, cost.CostType, cost.Cost, cost.Growth);
                total.Add(pastel);
            }
            return total;
        }
        public static List<PastelData> TotalIndividual(List<ProjectExpense> expenses)
        {
            List<PastelData> total = new List<PastelData>();
            foreach (var expense in expenses)
            {
                int n = expense.End - expense.Start;
                PastelData pastel = CrearPastel(expense.TypeGrowth, n, expense.TypeExpense, expense.Expense, expense.Growth);
                total.Add(pastel);
            }
            return total;
        }
        public static List<PastelData> TotalIndividual(List<InvesmentArea> inversiones)
        {
            List<PastelData> total = new List<PastelData>();
            foreach (var inversion in inversiones)
            {
                PastelData pastelData = new PastelData()
                {
                    Nombres = inversion.Name,
                    Valor = (inversion.Amount == 0) ? inversion.RecoveryCt : inversion.Amount
                };
                total.Add(pastelData);
            }
            return total;
        }
        private static PastelData CrearPastel(string tipoCrecimiento, int n, string nombre, decimal value, decimal crecimiento)
        {
            decimal valorPastel = 0;
            if (string.Compare(tipoCrecimiento, TipoCrecimiento.SinCrecimiento.ToString(), StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                valorPastel = value * (n + 1);
            }
            else if (string.Compare(tipoCrecimiento, TipoCrecimiento.Aritmetico.ToString(), StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                decimal valorFinal = value + (n * crecimiento);
                valorPastel = ((((value + crecimiento) + valorFinal) / 2) * n) + value;
            }
            else if (string.Compare(tipoCrecimiento, TipoCrecimiento.Geometrico.ToString(), StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                //TODO: ya que la base de datos no aceptaba decimales ocupe la siguiente linea para probar
                //cuando ya se puedan guardar decimales borrar esta linea y descomentar la otra
                double multiplicador = 1 + (double)crecimiento / 100;
                //double multiplicador = 1 + (double)crecimiento;
                double numerador = Math.Pow(multiplicador, n + 1) - 1;
                double denominador = multiplicador - 1;
                valorPastel = value * (decimal)(numerador / denominador);
            }
            return new PastelData() { Nombres = nombre, Valor = valorPastel };
        }

        #endregion
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
