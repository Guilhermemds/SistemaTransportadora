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
            m.MatriculaID = int.Parse(Matricula.Text);
            m.Nome = Nome.Text;
            m.Cpf = Cpf.Text;
            m.Telefone = Telefone.Text;
            m.Carteira = Carteira.Text;

            MotoristasController mc = new MotoristasController();
            mc.Adicionar(m);

            
        }

        private void listar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeComponent();

        }

        private void Janela_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarLista();
        }

        private void CarregarLista()
        {
            MotoristasController mc = new MotoristasController();
            listar.ItemsSource = mc.ListarTodos();           
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           MotoristasController mc = new MotoristasController();
           listar.ItemsSource = mc.ListarPorNome(Pesquisar.Text);

            //listar.ItemsSource = mc.Excluir();
            // listar.Items.Remove(listar.SelectedItem)            
        }

      private void Excluir(object sender, RoutedEventArgs e)
        {
            MotoristasController mc = new MotoristasController();
            int id = ((Motorista)listar.SelectedItem).MatriculaID;
            mc.Excluir(id);            
            MessageBox.Show("Motorista Excluido com sucesso");
        }
    }
}
