using EconomicMF.Domain.Entities.DataWithList;
using EconomicMF.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace EconomicMF.Services
{
    public static class CalculusOnMemory
    {
        public static int GetTerms(VidaUtilActivos vidaUtilActivos)
        {
            switch (vidaUtilActivos)
            {
                case VidaUtilActivos.Edificios_Industriales:
                    return 10;
                case VidaUtilActivos.Edificios_Comerciales:
                    return 20;
                case VidaUtilActivos.Residencia_Del_Propietario:
                    return 10;
                case VidaUtilActivos.Edificios_De_Alquiler:
                    return 30;
                case VidaUtilActivos.Instalaciones_fijas_en_explotacion_agropecuaria:
                    return 10;
                case VidaUtilActivos.Colectivo_De_Carga:
                    return 5;
                case VidaUtilActivos.Vehiculo_De_Empresas_de_Alquiler:
                    return 3;
                case VidaUtilActivos.Otros_Equipos_de_Transporte:
                    return 8;
                case VidaUtilActivos.Maquinaria_fija_en_bien_inmovil:
                    return 10;
                case VidaUtilActivos.Maquinaria_no_adherida_permanentemente:
                    return 7;
                case VidaUtilActivos.Otras_Maquinarias_y_Equipo:
                    return 5;
                case VidaUtilActivos.Equipos_de_Empresas_Agroindustriales:
                    return 5;
                case VidaUtilActivos.Equipos_Agricolas:
                    return 5;
                case VidaUtilActivos.Mobilario_y_Equipo_de_Oficina:
                    return 5;
                case VidaUtilActivos.Equipos_de_Comunicacion:
                    return 5;
                case VidaUtilActivos.Equipos_de_Computacion:
                    return 2;
                case VidaUtilActivos.Equipos_para_Medio_de_comunicacion:
                    return 2;
                case VidaUtilActivos.Ascensores:
                    return 10;
                case VidaUtilActivos.Elevadores:
                    return 10;
                case VidaUtilActivos.Unidad_de_Aire_Acondicionado:
                    return 10;
                case VidaUtilActivos.Otros_bienes_muebles:
                    return 5;
                case VidaUtilActivos.Terreno:
                    return 0;
                default:
                    return 0;
            }
        }

        public static string GetName(VidaUtilActivos vidaUtilActivos)
        {
            switch (vidaUtilActivos)
            {
                case VidaUtilActivos.Edificios_Industriales:
                    return "Edificios industrial";
                case VidaUtilActivos.Edificios_Comerciales:
                    return "Edificios comercial";
                case VidaUtilActivos.Residencia_Del_Propietario:
                    return "Residencia del propietario";
                case VidaUtilActivos.Edificios_De_Alquiler:
                    return "Edificio de alquiler";
                case VidaUtilActivos.Instalaciones_fijas_en_explotacion_agropecuaria:
                    return "Instalaciones fijas en explotación agropecuaria";
                case VidaUtilActivos.Colectivo_De_Carga:
                    return "Colectivo de carga";
                case VidaUtilActivos.Vehiculo_De_Empresas_de_Alquiler:
                    return "Vehiculo de empresas de alquiler";
                case VidaUtilActivos.Otros_Equipos_de_Transporte:
                    return "Otros equipos de transporte";
                case VidaUtilActivos.Maquinaria_fija_en_bien_inmovil:
                    return "Maquinaria fija en bien inmovil";
                case VidaUtilActivos.Maquinaria_no_adherida_permanentemente:
                    return "Instalaciones no adherida permanentemente";
                case VidaUtilActivos.Otras_Maquinarias_y_Equipo:
                    return "Otras maquinarias y equipo";
                case VidaUtilActivos.Equipos_de_Empresas_Agroindustriales:
                    return "Equipos de empresas agroindustriales";
                case VidaUtilActivos.Equipos_Agricolas:
                    return "Equipos agricolas";
                case VidaUtilActivos.Mobilario_y_Equipo_de_Oficina:
                    return "Mobiliario y equipo de oficina";
                case VidaUtilActivos.Equipos_de_Comunicacion:
                    return "Equipos de comunicación";
                case VidaUtilActivos.Equipos_de_Computacion:
                    return "Equipos de computación";
                case VidaUtilActivos.Equipos_para_Medio_de_comunicacion:
                    return "Equipos para medio de comunicación";
                case VidaUtilActivos.Ascensores:
                    return "Ascensores";
                case VidaUtilActivos.Elevadores:
                    return "Elevadores";
                case VidaUtilActivos.Unidad_de_Aire_Acondicionado:
                    return "Unidad de aire acondicionado";
                case VidaUtilActivos.Otros_bienes_muebles:
                    return "Otros bienes y muebles";
                case VidaUtilActivos.Terreno:
                    return "Terreno";
                default:
                    return "";
            }
        }

        public static decimal GetTmar(Project project)
        {
            decimal sum = project.Contribution * project.TMAR;

            foreach (var item in project.InvestmentEntities)
            {
                sum += item.Contribution * item.Rate;
            }
            return Math.Round(sum, 2);
        }
    }
}