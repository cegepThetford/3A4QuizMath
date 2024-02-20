using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMath_Affaire
{
    public class StatsReponses
    {
        private int _nbBonnesReponses;
        private int _nbReponses;

        public int NbBonnesReponses { get { return _nbBonnesReponses; } }
        public int NbMauvaisesReponses { 
            get { 
                return _nbReponses - _nbBonnesReponses; 
            } 
        }
        public int NbReponses { get { return _nbReponses; } }


        public StatsReponses()
        {
            _nbBonnesReponses = 0;
            _nbReponses = 0;
        }

        public void inscrireBonneReponse()
        {
            // COMPLETER
        }
        public void inscrireMauvaiseReponse()
        {
            // COMPLETER
        }

        public double calculerMoyenne()
        {
            double moy = 0.0;
            // seulement diviser si le nombre de réponse est supérieur à zéro
            // ATTENTION à ne pas faire une division entière

            return moy;
        }
    }
}
