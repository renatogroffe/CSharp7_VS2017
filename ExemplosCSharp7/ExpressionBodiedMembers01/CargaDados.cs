using System.IO;

namespace ExpressionBodiedMembers01
{
    class CargaDados
    {
        private string _tempDir;

        /*public CargaDados(string diretorioTemporario)
        {
            _tempDir = diretorioTemporario;
        }

        ~CargaDados()
        {
            Directory.Delete(_tempDir);
        }*/

        public CargaDados(string diretorioTemporario) =>
            _tempDir = diretorioTemporario;

        ~CargaDados() => Directory.Delete(_tempDir);

        public void Processar()
        {
            Directory.CreateDirectory(_tempDir);
            
            // Instruções para a carga de dados...
        }
    }
}