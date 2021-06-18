using System;

namespace projeto_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Boa tarde");

            //Comandos Git
            //git init - cria diretório
            //git add . - utilizado para commitar os arquivos e pastas
            //git status - Mostra todos os arquivos commitados e não comittados
            //git commit -m "Mensagem" - Serve para descrever o q aconteceu na committação
            //git log - mostra o q foi commitado, quem commitou e o que commitou

            //Se esquecer da mensagem no committ, o Git Bash abre um editor VIM.
            //Para sair do VIM tecle <ESC> ou <ENTER>, ou digite ":q!".

            //git reset --soft HEAD~1 |Remove o último commit mantendo as alterações nos arquivos.
            //git reset --hard HEAD~1 |Remove o último commit INCLUSIVE as alterações nos arquivos (PERIGO!).

            Console.WriteLine("Teste");

            //git checkout <código-do-commit> (4914a5c) | Navega entre commits, alterando arquivos temporariamente.
            //git checkout <nome-do-branch> (master) | Volta para o último commit.

            //git remote add origin <URI do repositorio remoto> |sincronizar repositorio local com o do github(remoto).
            //git remote set-url origin <URI do repositorio remoto> |Sincroniza o repositório local com outro repositorio remoto(modifica)




        }
    }
}
