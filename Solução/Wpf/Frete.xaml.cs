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
using System.Windows.Shapes;
using Controller;
using Modelos;

namespace Wpf
{
    /// <summary>
    /// Lógica interna para Frete.xaml
    /// </summary>
    public partial class Frete : Window
    {
        public Frete()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            FreteModelo fte = new FreteModelo();
            string tipoCarteira = "Carro";

            if(tipoCarteira.Equals(Carteira.Text))
            {
                
                fte.data = Data.Text;
                double distanciaFrete = double.Parse(Distancia.Text);
                fte.Carteira = Carteira.Text;
                fte.DistanciaPercorrida = distanciaFrete;
                fte.totalFrete = distanciaFrete * 4.50;

                FreteController salvarFrete = new FreteController();
                salvarFrete.Adicionar(fte);
                LimpaTela();
            }
            else
            {
                double distanciaFrete = double.Parse(Distancia.Text);
                fte.totalFrete = distanciaFrete * 3.50;
                fte.data = Data.Text;
                fte.Carteira = Carteira.Text;
                fte.DistanciaPercorrida = distanciaFrete;

                FreteController salvarFrete = new FreteController();
                salvarFrete.Adicionar(fte);
                LimpaTela();
            }

            CarregarLista();
        }

       

        void LimpaTela()
        {

            Data.Text = Distancia.Text = Carteira.Text = null;

        }
        private void CarregarLista()
        {
            FreteController fc = new FreteController();
            listar.ItemsSource = fc.ListarTodos();

        }

        private void Janela_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarLista();
        }
    }
}
