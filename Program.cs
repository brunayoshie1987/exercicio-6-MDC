using System;

namespace Exercicio_6___MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- MDC --------------");

            Console.WriteLine("Digite o primeiro número inteiro");

            var n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro");

            var n2 = Convert.ToInt32(Console.ReadLine());

            var achouMDC = false;
            var nrPrimo = 1.0;
            var multiplicacao = 0.0;
            var testesN1 = n1;
            var testesN2 = n2;

            while (!achouMDC)
            {
                nrPrimo = RetornarProximoNumeroPrimo(nrPrimo);

                var divisaotestesN1 = Convert.ToDouble(testesN1);
                var restoDivisaotestesN1 = 1.0;

                if (testesN1 != 1)
                {
                    divisaotestesN1 = testesN1 / nrPrimo;
                    restoDivisaotestesN1 = testesN1 % nrPrimo;
                }

                var divisaotestesN2 = Convert.ToDouble(testesN2);
                var restoDivisaotestesN2 = 1.0;

                if (testesN2 != 1)
                {
                    divisaotestesN2 = testesN2 / nrPrimo;
                    restoDivisaotestesN2 = testesN2 % nrPrimo;
                }

                if (restoDivisaotestesN1 == 0 && restoDivisaotestesN2 == 0)
                {
                    if (multiplicacao == 0)
                    {
                        multiplicacao += nrPrimo;
                    }
                    else
                    {
                        multiplicacao = multiplicacao * nrPrimo;
                    }

                    nrPrimo = 1;
                }

                if (restoDivisaotestesN1 > 0)
                {
                    divisaotestesN1 = testesN1;
                }

                if (restoDivisaotestesN2 > 0)
                {
                    divisaotestesN2 = testesN2;
                }

                testesN1 = Convert.ToInt32(divisaotestesN1);
                testesN2 = Convert.ToInt32(divisaotestesN2);

                if (testesN1 == 1 && testesN2 == 1)
                {
                    achouMDC = true;
                }
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("O MDC de " + n1 + " e " + n2 + " é " + multiplicacao);

            Console.ReadKey();
        }

        private static double RetornarProximoNumeroPrimo(double valor)
        {
            var resultado = 1.0;
            var isPrimo = false;

            while (!isPrimo)
            {
                var valorTeste = valor + 1.0;

                for (double x = valorTeste; x > 0; x--)
                {
                    var resto = valorTeste % x;

                    if (resto > 0 || valorTeste == x || x == 1)
                    {
                        resultado = valorTeste;
                        isPrimo = true;
                    }
                    else
                    {
                        valor++;
                        isPrimo = false;
                        break;
                    }
                }
            }

            return resultado;
        }
    }
}
