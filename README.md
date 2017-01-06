
# Découverte ASP.NET CORE et son écosystème

##Historique
- Explication de .NET avant .NET Core 
    - https://docs.microsoft.com/en-us/dotnet/articles/core/
    - https://blogs.msdn.microsoft.com/dotnet/2016/09/26/introducing-net-standard/
    
- Montrer l'utilitaire dotnet cli et créer une app console et la faire tourner

- Explication de ASP.NET avant ASP.NET Core 
    - https://docs.microsoft.com/en-us/aspnet/core/
- Montrer comment on transforme une console app en web app (montrer le main)

- Expliquer que par défaut on tourne sous Kestrel (mini web server) et qu'il faut toujours un IIS ou un serveur NGINX
    - Dessiner sur la surface de Simon :)

##Focus ASP.NET CORE
 - Parler Middleware
    - https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware
 - Creer un projet depuis ce template ci-dessous avec VS 2017 ou yeoman et l'exécuter
    - http://blog.stevensanderson.com/2016/10/04/angular2-template-for-visual-studio/ 
    - https://github.com/aspnet/JavaScriptServices/
 - Expliquer les midlewares de bases : Log, static, mvc, TODO
 - Expliquer l'injection de l'inpendance => bout de code à faire

##Focus sur Visual Studio Code
- Explication de Visual Studio Code et Omnisharp
    -- Démo: Electron, Plugin "KeyBinding"
- Démo debug application

# Pourquoi notre présentation est cool

## Motivations 
La plateforme .Net est devenu open source et su fort s’adapter/évoluer. La plateforme .NET Core fonctionne et est supportée sur tous les OS. Le langage typé C# lui aussi évolue. Ayant un background Node.js et Java, nous sommes persuadés que .NET Core à toute sa place : Légère, performante, multi-OS
Microsoft a beaucoup copié le monde open source et notamment « node.js ». Cette plateforme possède une architecture évolutive qui est pratique pour :
- le Cloud, 
- l’IOT,
- Les micro service. 
- Le Server side rendering (angular2, React)

La plateforme .NET existe depuis longtemps, elle bénéficie d’un très gros background de librairies existantes.
Nous sommes persuadés que pour développé itérativement, efficacement, l'éco-système .Net Core est au top su top!

## Ce que va apporter la présentation
.NET est une plateforme qui a un fort historique, le but est de re-contextualiser .Net Core dans cet historique.
Notre but est de guider sur :
- La philosophie et l'architecture
- Comment démarrer un projet sur la plateforme .Net Core
- Montrer .Net Core sur un environnement Windows et Linux (Ubuntu)
- Les fonctionnalités de base du Framework ASP.NET Core et tout ce que l'on peut faire (Injection dépendance, server side rendering, etc.)
- Expliquer les outils associés
    - Focus Visual Studio Code et comment debugger 
- Comment réaliser les tests unitaires
- RoadMap de comment migrer une application AXA en ASP.NET Core.

Une fois la présentation terminée, vous avez aurez une vision assez large pour vous orientez vers cette technologie et démarer à coder.

## On va réaliser plusieurs fois la présentation afin de s'entraîner
- https://twitter.com/cyril_lakech/status/816942892866531328
- https://github.com/sdib/netcorelive

