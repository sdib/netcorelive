
# Découverte ASP.NET CORE et son écosystème

##Introduction
- https://www.microsoft.com/net/core/support/
##Context .NET - Simon
- Explication de .NET avant .NET Core 
    - https://docs.microsoft.com/en-us/dotnet/articles/core/
    - https://blogs.msdn.microsoft.com/dotnet/2016/09/26/introducing-net-standard/
    
- Montrer l'utilitaire dotnet cli et créer une app console et la faire tourner 
    - https://github.com/dotnet/core
    - Démo sur Windows dotnet new
    - Expliquer project.json, .lock
    - Expliquer que par défaut pas d'exe, séléction du runtime (optimisé) par rapport à la plateforme
            - https://docs.nuget.org/ndocs/schema/project.json
    - Expliquer Exemple librairie Aspose (basculer full dotnet framework)
    - Restaurer la preview 4 du SDK

##Context ASP.NET - Guillaume
- Explication de ASP.NET avant ASP.NET Core 
    - https://docs.microsoft.com/en-us/aspnet/core/

- Montrer comment on transforme une console app en web app (montrer le main)
    - Prendre la console app 
    - Expliquer project.json => project.csproj
    - Ajouter les packages nécessaires
    - Ajouter Startup.cs avec les 2 methodes configure
    - Dans le pipeline http renvoyer hello world en dur
    - Expliquer que par défaut on tourne sous Kestrel (mini web server) et qu'il faut toujours un IIS ou un serveur NGINX
        - https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/
        - Comparaison avec NodeJS => http://aldb.github.io/2016/07/14/differences-between-web-servers/

##Focus ASP.NET CORE - Simon
 - Parler Middleware 
    - https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware
    - Expliquer les midlewares de bases : Log, static, mvc, authent, pages d'erreurs en dev, customs 
    - Expliquer l'injection de l'inpendance => bout de code à faire
    - Expliquer le nouveau système de configuration

##Focus Eco système - Guillaume
- Creer un projet depuis ce template ci-dessous avec yeoman et l'exécuter - Guillaume Linux
    - http://blog.stevensanderson.com/2016/10/04/angular2-template-for-visual-studio/ 
    - https://github.com/aspnet/JavaScriptServices/
    - http://yeoman.io/
    - Explication de Visual Studio Code (http://electron.atom.io) et Omnisharp (https://github.com/omnisharp)
        - Démo: Plugin "KeyBinding", Debug 

##Focus test unitaire
- Creer un projet depuis ce template ci-dessous avec VS 2017 et l'exécuter 
    - Montrer dotnet watch
    - Montrer live tests 

##Conclusion
- Déploiement Azure - Simon
- Migration appli existante - Guillaume

##Questions / Réponses


# Pourquoi notre présentation est cool

## Motivations 
La plateforme .Net est devenue open source et a évolué. 
Avec .NET Core elle apporte beaucoup de nouvelles choses : 
- légèreté
- performance
- cross plateforme
- outils 

Nous sommes persuadés que .NET Core à toute sa place et saura répondre à tous nos besoins.
Microsoft s'est beaucoup inspiré du monde open source et notamment « node.js » pour batir .NET Core. 
Cette plateforme possède une architecture évolutive qui est orientée  :
- Cloud,
- IOT,
- Micro services,
- Server side rendering (angular2, React)

La plateforme .NET existe depuis longtemps, elle bénéficie d’un très gros background de librairies existantes.
Nous sommes persuadés que pour développer itérativement, efficacement, l'éco-système .Net Core est au top du top!

## Ce que va apporter la présentation
Notre objectif est d'éclaircir la plateforme .NET pour tous les publics.
Nous souhaitons nous concentrer sur la nouvelle plateforme .NET Core et sur le framwork ASP.NET Core.
En sortant de notre présentation, l'audience sera capable de :
- d'expliquer ce que sont .NET Core et ASP.NET Core en termes de philosophie et d'architecture
- démarrer un projet sur la plateforme .Net Core sur Linux ou Windows
- maitriser les fonctionnalités de base du Framework ASP.NET Core (Injection dépendance, server side rendering, etc...)
- utiliser les outils associés
- développer / debugguer avec Visual Studio Code  
- exécuter ses tests unitaires 
- d'expliquer ce que sont .NET Core et ASP.NET Core
- publier une application web sur le Cloud Azure

Enfin, le public aura connaissance de la roadmap et une vision pour migrer une application AXA en ASP.NET Core.

Une fois la présentation terminée, vous avez aurez une vision assez large pour vous orienter vers cette technologie et démarrer vos projets.

## On va réaliser plusieurs fois la présentation afin de s'entraîner
- https://twitter.com/cyril_lakech/status/816942892866531328
- https://github.com/sdib/netcorelive

