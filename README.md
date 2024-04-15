# README de l'application MegaCasting

Cette application permet d'ajouter, modifier et supprimer des données dans la base de données associée. Pour commencer, suivez les étapes ci-dessous :

## Étapes d'utilisation :

1. **Téléchargement :** Récupérez le code source en C# ainsi que le fichier .sql associé.

2. **Décompression :** Décompressez le fichier téléchargé et placez-le dans le répertoire souhaité sur votre ordinateur.

3. **Ouverture du projet :** Ouvrez le projet en lançant le fichier .sln avec votre Visual Studio.

4. **Configuration de la base de données :** Assurez-vous de placer le dossier contenant le fichier .sql dans votre système de gestion de base de données. Si vous utilisez phpMyAdmin, importez simplement le fichier .sql. Si vous utilisez une autre solution, vous pouvez migrer les données directement depuis l'application vers votre base de données (par exemple, SQL Server) sans avoir besoin du fichier ".sql" en utilisant les fichiers de migrations.

5. **Configuration du contexte de base de données :** Assurez-vous de bien configurer le fichier megacastingcontext.cs pour permettre un fonctionnement optimal de la base de données.

   - Pour SQL Server :
     ```csharp
     optionsBuilder.UseSqlServer("Server=localhost;Database=MegaCasting;Trusted_Connection=True;TrustServerCertificate=True;");
     ```

   - Pour phpMyAdmin :
     ```csharp
     optionsBuilder.UseMySQL("server=localhost;database=MegaCasting;user=username;password=password;");
     ```
     *Remarque : Si aucun mot de passe n'est requis, utilisez `password=(vide)`.*

6. **Lancement de l'application :** Une fois ces étapes effectuées sans erreur, vous pouvez normalement lancer l'application.

## Connexion à l'application :

1. **Identification :** Une fois que l'application est lancée, vous serez redirigé vers l'écran de connexion.

2. **Identifiants :** Pour accéder à l'application, veuillez utiliser les identifiants suivants : 
   - Adresse e-mail : `user1@example.com`
   - Mot de passe : `password1`

3. **Authentification :** Si les identifiants fournis sont corrects, vous serez connecté à l'application et pourrez accéder à toutes ses fonctionnalités.

4. **Erreur d'authentification :** En cas de saisie incorrecte des identifiants, un message d'erreur s'affichera, vous invitant à réessayer avec les bonnes informations d'identification.

5. **Navigation :** Une fois connecté, vous pourrez naviguer à travers les différentes fonctionnalités de l'application pour ajouter, modifier ou supprimer des données dans la base de données qui est associée.
