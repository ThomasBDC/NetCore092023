using Microsoft.AspNetCore.Mvc;
using NetCore092023.Models;

namespace NetCore092023.Controllers
{
    public class LiveController : Controller
    {
        [Route("/AllStudiLives")]
        public IActionResult Index()
        {
            //Récupérer un live 
            //J'aurais voulu le récupérer de la BDD
            List<LiveModel> allLives = new()
            {
                new LiveModel{
                    Id = 1,
                    Nom = " ASP.NET Core (1/6) : Introduction",
                    Description = "Dans ce premier live, nous vous introduirons à ASP.NET Core, un framework de développement web. Vous découvrirez les bases de la création d'applications web avec ASP.NET Core, y compris la configuration de l'environnement de développement et la mise en place d'un projet.",
                    Url = "https://app.studi.fr/v3/events/57974/details"
                },
                new LiveModel{
                    Id = 2,
                    Nom = " ASP.NET Core (2/6) : Les controleurs (MVC)",
                    Description = "On parle de MVC",
                    Url = "https://app.studi.fr/v3/events/57975/details"
                },
                new LiveModel{
                    Id = 3,
                    Nom = " ASP.NET Core (3/6) : RAZOR",
                    Description = " Dans ce troisième live, nous aborderons les vues dans ASP.NET Core. Vous découvrirez comment créer des vues en utilisant Razor, un langage de template puissant pour générer du contenu HTML. Nous verrons également comment utiliser les modèles de vue pour afficher des données dans vos vues.",
                    Url = "https://app.studi.fr/v3/events/57976/details"
                },
                new LiveModel{
                    Id = 4,
                    Nom = " ASP.NET Core (4/6) : Les formulaires\r\n",
                    Description = "Lors de ce quatrième live, nous plongerons dans les formulaires dans ASP.NET Core. Vous apprendrez à créer des formulaires pour collecter des données auprès des utilisateurs, à valider les entrées et à gérer les soumissions de formulaire. Nous aborderons également la sécurité des formulaires et la protection contre les attaques CSRF.",
                    Url = "https://app.studi.fr/v3/events/57977/details"
                },
                new LiveModel{
                    Id = 5,
                    Nom = " ASP.NET Core (5/6) : LINQ\r\n",
                    Description = "Dans ce live, nous allons découvrir ce qu'est Linq, à quoi ça sert, et comment ça fonctionne.",
                    Url = "https://app.studi.fr/v3/events/57979/details"
                },
                new LiveModel{
                    Id = 6,
                    Nom = " ASP.NET Core (6/6) : Authentification\r\n",
                    Description = "Dans ce cinquième live, nous verons l'authentification dans ASP.NET Core. Vous apprendrez à sécuriser votre application web en mettant en place des mécanismes d'authentification et d'autorisation. Nous aborderons les principes de base de l'authentification, la gestion des utilisateurs, l'utilisation de rôles et de politiques.",
                    Url = "https://app.studi.fr/v3/events/57981/details"
                },
            };
            
            //vue Views/Live/Index.cshtml et donne lui l'objet
            return View(nameof(Index), allLives);
        }
    }
}
