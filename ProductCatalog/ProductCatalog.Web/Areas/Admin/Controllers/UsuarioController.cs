using ProductCatalog.DAO;
using ProductCatalog.Model;
using ProductCatalog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductCatalog.Web.Areas.Admin.Controllers
{
    public class UsuarioController : Controller
    {
        DataContext contextoBd;

        //Construtor para inicializar o serviço
        public UsuarioController()
        {
            contextoBd = new DataContext();
        }

        // GET: Admin/Usuario
        public ActionResult Index()
        {
            //Inicializa o serviço do banco de dados para a tabela usuario
            var usuarioServicoBd = new UsuarioService(contextoBd);

            //Cria lista de usuarios a partir dos registros do BD
            var listaUsuarios = usuarioServicoBd.Listar();
            
            //Envia para a view a lista
            return View(listaUsuarios);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Usuario usuario)
        {
            //Verifica se o modelo de dados é válido
            if (ModelState.IsValid)
            {
                //Inicializa o serviço do banco de dados para a tabela usuario
                var usuarioServicoBd = new UsuarioService(contextoBd);

                //Executa comando de inserção
                usuarioServicoBd.Inserir(usuario);

                //Executa o serviço no banco de dados
                contextoBd.SaveChanges();
            }

            return View();
        }

        public ActionResult Alterar(int id)
        {
            //Inicializa o serviço do banco de dados para a tabela usuario
            var usuarioServicoBd = new UsuarioService(contextoBd);

            //Executa comando de edição
            var usuario = usuarioServicoBd.BuscarPorCodigo(id);

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Alterar(Usuario usuario)
        {

            //Verifica se o modelo de dados é válido
            if (ModelState.IsValid)
            {
                //Inicializa o serviço do banco de dados para a tabela usuario
                var usuarioServicoBd = new UsuarioService(contextoBd);

                //Executa comando de edição
                usuarioServicoBd.Alterar(usuario);

                //Executa o serviço no banco de dados
                contextoBd.SaveChanges();
            }

            return View();
        }
    }
}
