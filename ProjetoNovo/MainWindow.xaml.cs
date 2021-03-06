using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoNovo
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btSalvar(object sender, RoutedEventArgs e)
        {


            //..INFORMAÇÕES  REGISTRO..//

            string nomeFantasia = txtRazaoSocial.Text;
            string cnpj = txtCNPJ.Text;
            string inscricaoEstadual = txtInsEstadual.Text;
            DatePicker dataCriacao = datePicDataCriação;
            string responsavel = txtResponsavel.Text;
            string tipo = "";

            //...INFORMAÇÕES DE  LOCALIZAÇÃO...//

            string rua = txtRua.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro.Text;
            string complemento = txtComplemento.Text;
            string cep = txtCEP.Text;
            string cidade = txtCidade.Text;
            string estado = txtEstado.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;

            if (Publico.IsChecked == true)
            {
                tipo= Publico.Content.ToString();
            }

            if (Privado.IsChecked == true)
            {
                tipo = Privado.Content.ToString();

            }

            MessageBox.Show("<<<<SALVO COM SUCESSO>>>>" + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                "Nome Fantasia:" + nomeFantasia + Environment.NewLine +
                "CNPJ:" + cnpj + Environment.NewLine +
                "Inscrição Estadual:" + inscricaoEstadual + Environment.NewLine +
                "Tipo:" + tipo + Environment.NewLine +
                "Responsável:" + responsavel + Environment.NewLine +
                "Data Criação:" + dataCriacao + Environment.NewLine +
                "Rua:" + rua + Environment.NewLine +
                "Numero:" + numero + Environment.NewLine +
                "Bairro:" + bairro + Environment.NewLine +
                "Complemento:" + complemento + Environment.NewLine +
                "CEP:" + cep + Environment.NewLine +
                "Cidade:" + cidade + Environment.NewLine +
                "Estado:" + estado + Environment.NewLine +
                "Telefone:" + telefone + Environment.NewLine +
                "Email:" + email + Environment.NewLine);

                 txtRazaoSocial.Clear();
                 txtCidade.Clear();
                 txtInsEstadual.Clear();
                 txtResponsavel.Clear();
                 datePicDataCriação.SelectedDate = null;
                 txtRua.Clear();
                 txtCNPJ.Clear();
                 txtNumero.Clear();
                 txtBairro.Clear();
                 txtComplemento.Clear();
                 txtCEP.Clear();
                 txtCidade.Clear();
                 txtTelefoneEscola.Clear();
                 txtEstado.Clear();
                 txtTelefone.Clear();
                 txtEmail.Clear();
                 Publico.IsChecked = false;
                 Privado.IsChecked = false;  







        }
    }
}
