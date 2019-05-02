using System;

namespace Altairis.AskMe.Web.DotVVM.ViewModels {
    public class ErrorViewModel : MasterPageViewModel {
        public ErrorViewModel(Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
            : base(env) {
        }

        public string Message {
            get {
                var errorCode = Convert.ToInt32(this.Context.Parameters["errorCode"]);

                switch (errorCode) {
                    case 404:
                        return "Po�adovan� str�nka neexistuje!";
                    case 500:
                        return "Vnit�n� chyba serveru";
                    default:
                        return "P�i zpracov�n� va�eho po�adavku do�lo k ne�ekan� chyb�.";
                }
            }
        }

        public override string PageTitle {
            get {
                var errorCode = Convert.ToInt32(this.Context.Parameters["errorCode"]);
                return $"HTTP chyba {errorCode}";
            }
        }
    }
}

