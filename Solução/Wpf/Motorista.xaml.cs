using Controller;
using Modelos;
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

namespace Wpf
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

        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            Motorista m = new Motorista();         
            m.Nome = Nome.Text;
            m.Cpf = Cpf.Text;
            m.Telefone = Telefone.Text;
            m.Carteira = Carteira.Text;

            MotoristasController mc = new MotoristasController();
            mc.Adicionar(m);
            LimpaTela();
            

        }


        void LimpaTela()
        {

            Nome.Text = Cpf.Text = Telefone.Text = Carteira.Text = " ";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Tabela tabela = new Tabela();
            this.Close();
            tabela.ShowDialog();
            
            
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {

            Frete fte = new Frete();
            this.Close();
            fte.ShowDialog();
            

        }
    }
}
