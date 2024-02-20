using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMath_Affaire
{
    public class Formule
    {
        private int _operande1, _operande2;
        private char _operateur;

        public int Operande1 { get { return _operande1; } set { _operande1 = value; } }
        public int Operande2 { get { return _operande2; } set { _operande2 = value; } }
        public char Operateur { get { return _operateur; } set { _operateur = value; } }

        public Formule()
        {
            // Générer les valeurs des deux opérandes (entre 2 et 12 inclusivement)

            // Générer un nombre entre 0 et 2 inclusivement
            // L'opérateur sera '+' si zéro, '-' si 1 et '*' autrement

            // Pour une soustraction, si l'opérande #1 est inférieure à
            // l'opérande #2, inverser les deux valeurs
            // NOTE: Se servir d'une variable temporaire pour faire l'échange

        }

        public int calculerReponse()
        {
            int resultat = 0;
            // Selon l'opérateur, faire l'addition, la soustraction ou la multiplication

            return resultat;
        }
    }
}
