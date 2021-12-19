# guess-my-age
Mon code à l'air de fonctionner pas d'erreurs,
l'implementation des classes et interfaces Game
Deux endpoints en GET et POST, via l'API qui tournent bien qui permettent de créer un jeu et de retourner l'ensemble des jeux.

# Correction

Avant de convertir de model vers databaseEntity, il te fallait modifier le model pour qu'il contienne les propriétés à convertir.
En ce qui concerne les converters tu appellais les méthodes en récursif, je te laisse regarder ce que j'ai fait...
Pour le reste, c'est pas si mal, hormis le fait que tu utilises directement le dbContext dans ton service. Il faut éviter et créer un repository pour le faire.

En réalité, il fallait créer un nouvel objet GameModel, différent de celui utilisé par l'application, pour bien faire...
Pour finir tu as oublié d'injecter le service dans un injector ou directement dans Program, comme j'ai fait, sinon il est inutilisable dans le constructeur.

