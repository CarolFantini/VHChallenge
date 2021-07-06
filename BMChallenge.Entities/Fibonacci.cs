using System;
using System.Collections.Generic;
using System.Linq;

namespace BMChallenge.Entities
{
    public class Fibonacci
    {
        public int primeiroTermo = 0;
        public int segundoTermo = 1;

        public List<int> returnSerie(int elements)
        {
            int aux;
            List<int> sequence = new List<int>();

            sequence.Add(primeiroTermo);
            sequence.Add(segundoTermo);

            for (int i = 2; i < elements; i++)
            {
                aux = primeiroTermo;
                primeiroTermo = segundoTermo;
                segundoTermo = primeiroTermo + aux;
                sequence.Add(segundoTermo);
            }
            return sequence;
        }
    }
}
