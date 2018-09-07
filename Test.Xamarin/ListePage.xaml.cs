using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Test.Xamarin
{
    public partial class ListePage : ContentPage
    {
        public ListePage()
        {
            InitializeComponent();
            List<Article> articles;
            articles = new List<Article>();

            articles.Add(new Article { Name = "Friandises pour chat", Price = "25€" });
            articles.Add(new Article { Name = "Friandises pour chien", Price = "20€" });
            articles.Add(new Article { Name = "Friandises pour developpeurs", Price = "45€" });
            articles.Add(new Article { Name = "Friandises pour président", Price = "2135€" });
            articles.Add(new Article { Name = "Friandises pour lapin", Price = "15€" });
            articles.Add(new Article { Name = "Friandises pour astronaute", Price = "205€" });

            listArticle.ItemsSource = articles;
            listArticle.ItemSelected += (sender, e) =>
            {
                Article item = listArticle.SelectedItem as Article;
                if (listArticle.SelectedItem != null) {
                    DisplayAlert(item.Name, "Prix : "+item.Price, "Ok");
                    listArticle.SelectedItem = null;
                }
              
            }; 

        }
    }

    public class Article
    {
        public String Name { get; set; }
        public String Price { get; set; }

    }
}
