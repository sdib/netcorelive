# BBL ASP.NET CORE 

##Historique
- Explication de .NET avant .NET Core 
    - https://docs.microsoft.com/en-us/dotnet/articles/core/
    - https://blogs.msdn.microsoft.com/dotnet/2016/09/26/introducing-net-standard/
    
- Montrer l'utilitaire dotnet cli et créer une app console et la faire tourner

- Explication de ASP.NET avant ASP.NET Core 
    - https://docs.microsoft.com/en-us/aspnet/core/
- Montrer comment on transforme une console app en web app (montrer le main)

- Expliquer que par défaut on tourne sous Kestrel (mini web server) et qu'il faut toujours un IIS ou un serveur NGINX
-- Dessiner sur la surface de Simon :)

##Focus ASP.NET CORE
 - Parler Middleware
    - https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware
 - Creer un projet depuis ce template ci-dessous avec VS 2017 et l'exécuter
    - http://blog.stevensanderson.com/2016/10/04/angular2-template-for-visual-studio/ 
 - Expliquer les midlewares de bases : Log, static, mvc, TODO
 - Expliquer l'injection de l'inpendance => bout de code à faire


##TODO

Allo Simon, on se fait une super API qui répond des questions :
```
POST
Api/ask
{ 
    name: "Guillaume",
    question: "Quel temps sera-t-il demain?"
}
```

##Simon Sous windows 10
- Création projet Console avec dotnetcli et exécution explication
- Création projet ASP.NET CORE avec dotnetcli et explication des nouveautés
- Conversion du projet avec VS 2017 et explication de l’histoire des outils de build
- Git init
- Git push

##Guillaume sous unbuntu
- Git clone
- Exécution du projet
- Présentation VS Code (plugin, proxy, basé sur le Framework electron)
- Comment débugger le C#
- Explication de Omnisharp
- Ajouter un bout de code et son test unitaire
- Git push

##Simon Sous Windows 10
- Ajout d’un lib StringTemplate 4.5.2 pour faire du templating => Changement de Framework
- Expliquer la cible .Net Standard
- Montrer outil de migration des projets 
- RoadMap de comment migrer une application AXA en ASP.NET Core.
- MVC6 => OWIN => ASP.NET Core avec Middleware Owin
