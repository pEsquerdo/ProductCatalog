using ProductCatalog.DAO;
using ProductCatalog.Model;
using ProductCatalog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            //using - Destroy o objeto ao término do uso
            //Instancializamos o Contexto do Banco de Dados
            using (DataContext ctx = new DataContext())
            {
                var cat1 = new Categoria() { Titulo = "Alimentos", Imagem = "alimentos.jpg" };
                var cat2 = new Categoria() { Titulo = "Sapatos", Imagem = "sapatos.jpg" };
                var cat3 = new Categoria() { Titulo = "Eletrônicos", Imagem = "eletronicos.jpg" };
                var cat4 = new Categoria() { Titulo = "Móveis", Imagem = "moveis.jpg" };
                var cat5 = new Categoria() { Titulo = "Celulares", Imagem = "celulares.jpg" };

                //Instancializo a Service para as Ações de Categorias e passo o Contexto para o Construtor
                CategoriaService categoriaService = new CategoriaService(ctx);
                categoriaService.Inserir(cat1);
                categoriaService.Inserir(cat2);
                categoriaService.Inserir(cat3);
                categoriaService.Inserir(cat4);
                categoriaService.Inserir(cat5);

                //Inserir 3 Usuarios
                var usu1 = new Usuario() { Nome = "Pedro Esquerdo", Email = "pesquerdo@gmail.com", Senha = "pesquerdo", Telefone = "17-99217-9836 " };
                var usu2 = new Usuario() { Nome = "João Amoedo", Email = "jamoedo@gmail.com", Senha = "jamoedo", Telefone = "17-99217-9836 " };
                var usu3 = new Usuario() { Nome = "Luis Inacio Lula da Silva", Email = "lula@gmail.com", Senha = "lula", Telefone = "17-99217-9836 " };

                UsuarioService usuarioService = new UsuarioService(ctx);
                usuarioService.Inserir(usu1);
                usuarioService.Inserir(usu2);
                usuarioService.Inserir(usu3);

                ctx.SaveChanges();
            }
        }
    }
}
