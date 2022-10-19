using EconomicEF.Infraestructure.Repository;
using EconomicMF.Domain.Contracts;
using EconomicMF.Forms;
using EconomicMF.Forms.Forms.Users;
using EconomicMF.Forms.FormsCalculations;
using EconomicMF.Forms.FormsFlujo;
using EconomicMF.Forms.FormsMain;
using EconomicMF.Forms.FormsProject;
using EconomicMF.Forms.FormsProject.FNE;
using EconomicMF.Forms.FrmInitProjects;
using EconomicMF.Helper;
using EconomicMF.UserControls;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace EconomicMF.SettingForms
{
    public static class SingletonFrm
    {

        private static ServiceCollection serviceDescriptors = null!;

        public static Form GetForm(FormType formType)
        {
            switch (formType)
            {
                case FormType.Login:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmLogin>();
                case FormType.Register:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmRegister>();
                case FormType.Solution:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmSolution>();
                case FormType.Main:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmMain>();
                case FormType.Others:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmOthers>();
                case FormType.AddSolution:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmAddSolution>();
                case FormType.AddInvestor:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmAddInvestors>();
                case FormType.CreateProject:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmCreateProject>();
                case FormType.FlowMain:
                    return ServicesReq.ServiceProvider.GetRequiredService<FormMain>();
                case FormType.ChargeData:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmChargeData>();
                case FormType.Cost:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmAddCosto>();
                case FormType.Entry:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmAddEntry>();
                case FormType.Inversion:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmAddInversion>();
                case FormType.Start:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmStart>();
                case FormType.DashBoard:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmDashboard>();
                case FormType.Inversors:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmInversors>();
                case FormType.Reporte:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmReporte>();
                case FormType.Annuaty:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmAnnuaty>();
                case FormType.Calculus:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmCalculus>();
                case FormType.Conversor:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmConversor>();
                case FormType.ConvertTime:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmConvertTime>();
                case FormType.Interesp:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmInteresp>();
                case FormType.ForgotPassword:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmForgotPassword>();
                case FormType.ValidateUser:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmValidateForgotPass>();
                case FormType.ValidateRegister:
                    return ServicesReq.ServiceProvider.GetRequiredService<frmValidateUser>();
                case FormType.ConfigInit:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmConfigInit>();
                case FormType.AddGasto:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmAddExpense>();
                case FormType.AddAsset:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmAddAsset>();
                case FormType.OtherDep:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmDepreciacion>();
                case FormType.OtherAmt:
                    return ServicesReq.ServiceProvider.GetRequiredService<FrmAmortizacion>();
                default:
                    throw new Exception("Error");
            }   
        }

        public static void GetInstances(this ServiceCollection services)
        {
            serviceDescriptors = services;
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<FrmLogin>();
            services.AddSingleton<FrmRegister>();
            services.AddSingleton<FrmSolution>();
            services.AddSingleton<FrmValidateForgotPass>();
            services.AddSingleton<FrmMain>();
            services.AddSingleton<FrmOthers>();
            services.AddSingleton<FrmAddSolution>();
            services.AddSingleton<FrmAddInvestors>();
            services.AddSingleton<FrmCreateProject>();
            services.AddSingleton<FormMain>();
            services.AddSingleton<FrmChargeData>();
            services.AddSingleton<FrmAddCosto>();
            services.AddSingleton<FrmAddEntry>();
            services.AddSingleton<FrmAddInversion>();
            services.AddSingleton<FrmDashboard>();
            services.AddSingleton<FrmStart>();
            services.AddSingleton<FrmChargeData>();
            services.AddSingleton<FrmInversors>();
            services.AddSingleton<FrmReporte>();
            services.AddSingleton<FrmAnnuaty>();
            services.AddSingleton<FrmCalculus>();
            services.AddSingleton<FrmConversor>();
            services.AddSingleton<FrmConvertTime>();
            services.AddSingleton<FrmInteresp>();
            services.AddSingleton<frmValidateUser>();
            services.AddSingleton<FrmForgotPassword>();
            services.AddSingleton<FrmConfigInit>();
            services.AddSingleton<FrmAddExpense>();
            services.AddSingleton<FrmAddAsset>();
            services.AddSingleton<UCProject>();
            services.AddSingleton<FrmAmortizacion>();
            services.AddSingleton<FrmDepreciacion>();
            services.AddSingleton<RepositoryOthers>();
        }      

        public static RepositoryOthers GetRepo()
        {
            return ServicesReq.ServiceProvider.GetRequiredService<RepositoryOthers>();
        }
    }
}
