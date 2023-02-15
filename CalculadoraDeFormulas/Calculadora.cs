
namespace CalculadoraDeFormulas
{
    internal class Calculadora
    {
        public string Funcao { get; set; }
        public string Tipo { get; set; }


        public string Funcao_Quadratica(double a, double b, double c)
        {
            double x1 = 0, x2 = 0, Xvertice = 0, Yvertice = 0;
            string direcaoVertice = "";

            //Direção do Vertice da Parabola
            if (a > 0)
            {
                direcaoVertice = "Para Cima";
            }
            else if (a < 0)
            {
                direcaoVertice = "Para Baixo";
            }
            else
            {
                //Encerrar metodo pois não existe função quadratica sem "a"
            }

            //Calculo do Discriminante
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                //Fazer calculo para número complexo
            }
            else // delta >= 0
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }

            //Calculo do vertice da parabola
            Xvertice = -b / (2 * a);
            Yvertice = -delta / (4 * a);

            return $"x1 = {x1},\n" +
                $"x2 = {x2},\n" +
                $"Xvertice = {Xvertice},\n" +
                $"Yvertice = {Yvertice},\n" +
                $"Delta = {delta},\n" +
                $"Direção do Vertice = {direcaoVertice}";
            //Essa string deve seguir um padrão do resultado para poder ser separado com o .Split()
        }

        //Fisica Movimento Uniforme
        public string MovimentoUniforme(string? sF, string? sI, string? v, string? t)
        {
            double x = 0.0;
            //Se quiser Espaço Final
            if (sF == "")
            {
                double Si = double.Parse(sI);
                double V = double.Parse(v);
                double T = double.Parse(t);
                x = Si + V * T;
                return $"sF = {x}km";
            }
            //Se quiser Espaço Inicial
            else if (sI == "")
            {
                double Sf = double.Parse(sF);
                double V = double.Parse(v);
                double T = double.Parse(t);
                x = Sf - V * T;
                return $"sI = {x}km";
            }
            //Se quiser Velocidade
            else if (v == "")
            {
                double Sf = double.Parse(sF);
                double Si = double.Parse(sI);
                double T = double.Parse(t);
                x = (Sf - Si) / T;
                return $"v = {x}km/h";
            }
            //Se quiser Tempo
            else if (t == "")
            {
                double Sf = double.Parse(sF);
                double Si = double.Parse(sI);
                double V = double.Parse(v);
                x = (Sf - Si) / V;
                return $"t = {x}h";
            }
            else // Erro
            {
                return "Erro!!!";
            }

        }
    }
}