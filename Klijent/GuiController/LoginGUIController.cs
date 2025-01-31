using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonClases.Komunikacija;
using CommonLib.Domen;

namespace Klijent.GuiController
{
    public class LoginGuiController
    {

        private static LoginGuiController instance;
        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGuiController();
                }
                return instance;
            }
        }
        public FRMKorisnikLogin formaZaLogin;
        private LoginGuiController()
        {
        }
        public void ShowFormLogin()
        {

            if (Communication.Instance.Connect())
            {Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                formaZaLogin = new FRMKorisnikLogin();
                formaZaLogin.AutoSize = true;
                Application.Run(formaZaLogin);

            }
            
                
            
            
           

        }
        public bool Validacija()
        {
            if (string.IsNullOrEmpty( formaZaLogin.TxtUsername.Text) || string.IsNullOrEmpty(formaZaLogin.TxtPassword.Text)) {
                return false;
            }
            return true;
            

        }
        public void Login(Object sender, EventArgs e) {
            CommonLib.Domen.Administrator adm = new Administrator(null,null,formaZaLogin.TxtUsername.Text,formaZaLogin.TxtPassword.Text);
            if (Validacija()==false)
            {
                MessageBox.Show("Morate uneti vrednosti u polja");
                return;
            }
            Odgovor odgovor = Communication.Instance.Login(adm);
            if (odgovor.Exception == null)
            {
                formaZaLogin.Visible = false;
                MessageBox.Show($"Uspesno ste se ulogovali "+((Administrator)odgovor.Result).Ime, "Obavestenje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MainController.Instance.show((Administrator)odgovor.Result);
            }
            else {
                MessageBox.Show("Uneti administrator ne postoji!", "Greska pri Loginu-u", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
       
    }
}
