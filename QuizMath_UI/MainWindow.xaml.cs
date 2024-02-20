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
using QuizMath_Affaire;

namespace QuizMath_UI
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Déclarer les deux attributs (StatsReponses et Formule)
        public MainWindow()
        {
            InitializeComponent();
            // Créer un nouvel objet StatsReponses

            initialiserFormule();
            afficherStats();
        }

        private void initialiserFormule()
        {
            // Créer une nouvelle instance de Formule

            // modifier les opérandes et l'opérateur dans l'interface

            // vider le champ de réponse, et lui donner le focus

        }

        private void afficherStats()
        {
            // Ajuster, dans l'interface, le nombre de bonnes et mauvaises réponses

            // Afficher la moyenne: $"{______:0}%"

            // Ajuster la valeur de la barre de progression (nombre entre 0 et 100)

        }

        // Méthode associée à l'événement KeyDown
        // Si e.Key == Key.Enter
        //   si la conversion vers entier fonctionne
        //     si la réponse entrée correspond au résultat calculé de la formule
        //        inscrire une bonne réponse aux statistiques
        //     sinon
        //        inscrire une mauvaise réponse aux statistiques
        //   this.afficherStats();
        //   this.initialiserFormule();
    }
}
