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
using System.Windows.Shapes;

namespace Wpf
{
    /// <summary>
    /// Lógica interna para Tabela.xaml
    /// </summary>
    public partial class Tabela : Window
    {
        public Tabela()
        {
            InitializeComponent();
        }

        private void listar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeComponent();

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

                      
        }

        private void Excluir(object sender, RoutedEventArgs e)
        {
            MotoristasController mc = new MotoristasController();
            int id = ((Motorista)listar.SelectedItem).MotoristaID;            
            mc.Excluir(id);
            listar.ItemsSource = mc.ListarTodos();

        }

        private void Janela_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarLista();
        }

        private void Alterar(object sender, RoutedEventArgs e)
        {
            if (listar.SelectedIndex >= 0)
            {

                Motorista dgLinha = (Motorista)listar.SelectedItem;

                Nome.Text = dgLinha.Nome;
                Cpf.Text = dgLinha.Cpf;
                Telefone.Text = dgLinha.Telefone;

            }
        }

        
        
        private void Alte_Click(object sender, RoutedEventArgs e)
        {
            MotoristasController mc = new MotoristasController();

            Motorista m = new Motorista();           
            int id = ((Motorista)listar.SelectedItem).MotoristaID;
            
            // Motorista m = m.MotoristaID.ToString(Convert.ToInt32(ID.Text));

            m.MotoristaID = id;
            m.Nome = Nome.Text;            
            m.Cpf = Cpf.Text;
            m.Telefone = Telefone.Text;                        
            
            mc.Editar(m);

            CarregarLista();
        }
    }
}
