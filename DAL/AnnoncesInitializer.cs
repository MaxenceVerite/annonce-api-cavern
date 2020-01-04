using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace AnnonceAPI.DAL
{
    public class AnnoncesInitializer : CreateDatabaseIfNotExists<AnnoncesContext>
    {
        protected override void Seed(AnnoncesContext context)
        {
            base.Seed(context);

            var annonce0 = new Annonce_DAO()
            {
                Categorie = "Meubles",
                Auteur = "François59845",
                Intitule = "Canapé pliable 3 en 1",
                Description = "Je me sépare de ce joli canapé pliable parce que j'ai pris pour décision de ne plus m'assoir. Ca fait des années que j'y réfléchis mais je franchis le pas aujourd'hui. Le prix est non négociable. Vous pouvez me joindre sur Facebook également à 'François Dugolin'. A bientot bisous.",
                Prix = 240
                  
            };

            context.Annonces.Add(annonce0);
            context.SaveChanges();

            var annonce1 = new Annonce_DAO()
            {
                Categorie = "Meubles",
                Auteur = "CarineLaFolle",
                Intitule = "Porte en bois rustique",
                Description = "Ancienneté qui ira parfaitement avec une décoration art-déco. A donner au premier qui me contacte",
                Prix = 0

            };

            context.Annonces.Add(annonce1);
            context.SaveChanges();
            var annonce2 = new Annonce_DAO()
            {
                Categorie = "Animaux",
                Auteur = "DominiqueMauras11",
                Intitule = "Chat doux et attentionné",
                Description = "C'est par la volonté de mon chat que je m'en sépare, sinon je l'aurai bien gardé. Il souhaite une famille aimante, riche et qui pourra lui offrir des sachets de paté, pas de croquettes bas de gammes.",
                Prix = 30

            };

            context.Annonces.Add(annonce2);
            context.SaveChanges();

            var annonce3 = new Annonce_DAO()
            {
                Categorie = "Meubles",
                Auteur = "DominiqueMauras11",
                Intitule = "Ordinateur Gamer 2go de RAM, 1go de stockage",
                Description = "Au plus offrant. Rendez vous Parc Rouge pour discuter du prix. A 23h. Venez seul.",
                Prix = 2000

            };

            context.Annonces.Add(annonce3);
            context.SaveChanges();

            var annonce4 = new Annonce_DAO()
            {
                Categorie = "Meubles",
                Auteur = "KarineLeMarchand",
                Intitule = "Perruque blonde pour soirée déjantée",
                Description = "Pas cher du tout pour la qualité",
                Prix = 200

            };

            context.Annonces.Add(annonce4);
            context.SaveChanges();

            var annonce5 = new Annonce_DAO()
            {
                Categorie = "Meubles",
                Auteur = "LaurentFebvin",
                Intitule = "Cailloux décoratif granite massif",
                Description = "300g de Cailloux pour décorer votre intérieur. Provenance saharienne",
                Prix = 17

            };

            context.Annonces.Add(annonce5);
            context.SaveChanges();

            var annonce6 = new Annonce_DAO()
            {
                Categorie = "Meubles",
                Auteur = "François59845",
                Intitule = "Table très basse",
                Description = "Une table que j'ai personnellement placé devant mon canapé. Je m'en débarasse car je vends aussi mon canapé",
                Prix = 90

            };

            context.Annonces.Add(annonce6);
            context.SaveChanges();


            var annonce7 = new Annonce_DAO()
            {
                Categorie = "Animaux",
                Auteur = "TonkMelinda",
                Intitule = "Tigre du bengal",
                Description = "Tigre érant trouvé dans la rue. Possibilité d'achats par partie, mon mari est Boucher / Traiteur",
                Prix = 2400

            };

            context.Annonces.Add(annonce7);
            context.SaveChanges();

            var annonce8 = new Annonce_DAO()
            {
                Categorie = "Animaux",
                Auteur = "TonkMelinda",
                Intitule = "Elephant privé de ses défenses",
                Description = "Nous avons trouvé un éléphant privé de ses défenses. Nous l'offront à qui voudra s'en occuper de la façon qu'il mérite. Frais de transport de 24e",
                Prix = 24

            };

            context.Annonces.Add(annonce8);
            context.SaveChanges();

            var annonce9 = new Annonce_DAO()
            {
                Categorie = "Meubles",
                Auteur = "TonkMelinda",
                Intitule = "Table basse pieds en ivoire",
                Description = "Fais maison",
                Prix = 2200

            };

            context.Annonces.Add(annonce9);
            context.SaveChanges();
            

            var annonce10 = new Annonce_DAO()
            {
                Categorie = "Immobilier",
                Auteur = "FigueEtPassion1988",
                Intitule = "Immeuble style new-yorkais",
                Description = "A louer ou acheter en entier.",
                Prix = 220000045

            };

            context.Annonces.Add(annonce10);
            context.SaveChanges();

            var annonce11 = new Annonce_DAO()
            {
                Categorie = "Immobilier",
                Auteur = "XxMarieJosexX",
                Intitule = "Cabane en paille post-moderne",
                Description = " ",
                Prix = 2

            };

            context.Annonces.Add(annonce11);
            context.SaveChanges();

            var annonce12 = new Annonce_DAO()
            {
                Categorie = "Immobilier",
                Auteur = "XxMarieJosexX",
                Intitule = "Cabane dans les arbres",
                Description = " Une cabane à vendre ou lot de trois à -40%",
                Prix = 154400

            };

            context.Annonces.Add(annonce12);
            context.SaveChanges();

            var annonce13 = new Annonce_DAO()
            {
                Categorie = "HT",
                Auteur = "BobiaLaBobo",
                Intitule = "Liseuse electronique",
                Description = "Je préfère les livres papiers. Cela dénature l'essence même de la lecture. L'odeur de l'encre qui parcoure mes narines et le bruit des pages qui sifflent dans mon oreille. La société moderne m'epuise. ",
                Prix = 1

            };

            context.Annonces.Add(annonce13);
            context.SaveChanges();

            var annonce14 = new Annonce_DAO()
            {
                Categorie = "HT",
                Auteur = "BobiaLaBobo",
                Intitule = "Tele cathodique basse définition",
                Description = "J'ai acheté une télé 4K et me débarasse donc de la télé-cathodique que j'avais hérité de grand-maman. Elle ne me permettait pas de capté Cyril Hanouna en qualité optimale mais suffira à ceux qui se contente d'émission peu exigeante en effets spéciaux. ",
                Prix = 21

            };

            context.Annonces.Add(annonce14);
            context.SaveChanges();


            var annonce15 = new Annonce_DAO()
            {
                Categorie = "HT",
                Auteur = "MaxenceVérité80600",
                Intitule = "Fusil Laser créateur de portail dimensionel",
                Description = "Trop compliqué à utiliser je m'en sépare à bas prix.",
                Prix = 45

            };

            context.Annonces.Add(annonce15);
            context.SaveChanges();

            var annonce16 = new Annonce_DAO()
            {
                Categorie = "HT",
                Auteur = "MaxenceVérité80600",
                Intitule = "Club de golf avec système d'IA",
                Description = "Vise le green automatiquement puis se deconnecte",
                Prix = 8000

            };

            context.Annonces.Add(annonce16);
            context.SaveChanges();

            var annonce17 = new Annonce_DAO()
            {
                Categorie = "Vehicules",
                Auteur = "JackyTunning62",
                Intitule = "Bolide de compétition",
                Description = "Une belle renault 205 avec un moteur de Ferrari et une carosserie signé Electrolux",
                Prix = 80000

            };


            context.Annonces.Add(annonce17);
            context.SaveChanges();

            






        }
    }
}