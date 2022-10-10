using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.Domain.Enums
{
    public enum VidaUtilActivos
    {
        //Vida en años

        //EDIFICIOS
        Edificios_Industriales = 10,
        Edificios_Comerciales = 20,
        Residencia_Del_Propietario = 10,
        Edificios_De_Alquiler = 30,
        Instalaciones_fijas_en_explotacion_agropecuaria = 10,
        //EQUIPOS DE TRANSPORTE
        Colectivo_De_Carga = 5,
        Vehiculo_De_Empresas_de_Alquiler = 3,
        Otros_Equipos_de_Transporte = 8,
        //MAQUINARYA Y EQUIPO
        Maquinaria_fija_en_bien_inmovil = 10,
        Maquinaria_no_adherida_permanentemente = 7,
        Otras_Maquinarias_y_Equipo = 5,
        Equipos_de_Empresas_Agroindustriales = 5,
        Equipos_Agricolas = 5,
        //OTROS BIENES MUEBLES
        Mobilario_y_Equipo_de_Oficina = 5,
        Equipos_de_Comunicacion = 5,
        Equipos_de_Computacion = 2,
        Equipos_para_Medio_de_comunicacion = 2,
        Ascensores = 10,
        Elevadores = 10,
        Unidad_de_Aire_Acondicionado = 10,
        Otros_bienes_muebles = 5,
        //TERRENO
        Terreno
    }
}
