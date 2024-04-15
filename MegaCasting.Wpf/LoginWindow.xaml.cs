using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using MegaCasting.DBLib.Class;


namespace MegaCasting.Wpf
{
    public partial class LoginWindow : Window
    {

        private List<User> users = new List<User>
{
    new User("user1@example.com", "password1"),
    new User("user2@example.com", "password2")

};

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string email = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Recherche de l'utilisateur dans la liste en fonction de l'adresse e-mail
            User user = users.FirstOrDefault(u => u.Email == email);

            if (user != null && user.Password == password)
            {
                // Les informations d'identification sont valides, ouvrir la fenêtre principale
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                // Afficher un message d'erreur si les informations d'identification sont incorrectes
                ErrorMessage.Text = "Adresse e-mail ou mot de passe incorrect.";
                ErrorMessage.Visibility = Visibility.Visible;
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            // logique pour ouvrir la fenêtre d'inscription ou afficher la page d'inscription
        }
    }
}