namespace ExemploRefReturns
{
    public class ClasseExemplo
    {
        private int _contador = 0;

        public void Incrementar()
        {
            _contador++;
        }

        public int ObterValorContador()
        {
            return _contador;
        }

        public ref int ObterContador()
        {
            return ref _contador;
        }
    }
}