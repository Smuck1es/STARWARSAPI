using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void GetPlanet_Click(object sender, EventArgs e)
        {
            string planetID = txbID.Text;

            if (int.TryParse(planetID, out int id))
            {
                if (id >= 1 && id <= 61)
                {
                    Planet planet = await JSONHelper.GetPlanet(planetID);

                    string planetInfo = $"Name: {planet.name}\n" +
                               $"Rotation Period: {planet.rotation_period}\n" +
                               $"Orbital Period: {planet.orbital_period}\n" +
                               $"Diameter: {planet.diameter}\n" +
                               $"Climate: {planet.climate}\n" +
                               $"Gravity: {planet.gravity}\n" +
                               $"Terrain: {planet.terrain}\n" +
                               $"Surface Water: {planet.surface_water}\n" +
                               $"Population: {planet.population}\n" +
                               $"Residents: {string.Join(", ", planet.residents)}\n" +
                               $"Films: {string.Join(", ", planet.films)}\n" +
                               $"Created: {planet.created.ToString("yyyy-MM-dd HH:mm:ss")}\n" +
                               $"Edited: {planet.edited.ToString("yyyy-MM-dd HH:mm:ss")}\n" +
                               $"URL: {planet.url}";

                    lblInfo.Text = planetInfo;
                }
                else
                {
                    MessageBox.Show("Please enter a planet ID between 1 and 61");
                }

            }
            else 
            {
                MessageBox.Show("Please enter a planet ID");
            }
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void GetPerson_btn_Click(object sender, EventArgs e)
        {
            string personID = txbID.Text;

            if (int.TryParse(personID, out int id))
            {
                if (id >= 1 && id <= 87)
                {
                    Person person = await JSONHelper.GetPerson(personID);

                    string personInfo = $"Name: {person.name}\n" +
                                $"Height: {person.height}\n" +
                                $"Mass: {person.mass}\n" +
                                $"Hair Color: {person.hair_color}\n" +
                                $"Skin Color: {person.skin_color}\n" +
                                $"Eye Color: {person.eye_color}\n" +
                                $"Birth Year: {person.birth_year}\n" +
                                $"Gender: {person.gender}\n" +
                                $"Homeworld: {person.homeworld}\n" +
                                $"Films: {string.Join(", ", person.films)}\n" +
                                $"Species: {string.Join(", ", person.species)}\n" +
                                $"Vehicles: {string.Join(", ", person.vehicles)}\n" +
                                $"Starships: {await GetStarshipsNames(person.starships)}\n" +
                                $"Created: {person.created.ToString("yyyy-MM-dd HH:mm:ss")}\n" +
                                $"Edited: {person.edited.ToString("yyyy-MM-dd HH:mm:ss")}\n" +
                                $"URL: {person.url}";

                    lblInfo.Text = personInfo;
                }
                else
                {
                    MessageBox.Show("Please enter a planet ID between 1 and 87");
                }

            }
            else
            {
                MessageBox.Show("Please enter a person ID");
            }
        }

        private async Task<string> GetStarshipsNames(List<string> starshipUrls)
        {
            List<string> starshipNames = new List<string>();

            foreach (string url in starshipUrls) 
            {

                Starship starship = await JSONHelper.GetStarshipName(url);
                starshipNames.Add(starship.name);
            }

            return string.Join(", ", starshipNames);
        }

        private async void GetSpecies_btn_Click(object sender, EventArgs e)
        {
            string speciesID = txbID.Text;

            if (int.TryParse(speciesID, out int id))
            {
                if (id >= 1 && id <= 37)
                {
                    Species species = await JSONHelper.GetSpecies(speciesID);

                    string speciesInfo = $"Name: {species.name}\n" +
                                     $"Classification: {species.classification}\n" +
                                     $"Designation: {species.designation}\n" +
                                     $"Average Height: {species.average_height}\n" +
                                     $"Average Lifespan: {species.average_lifespan}\n" +
                                     $"Eye Colors: {species.eye_colors}\n" +
                                     $"Hair Colors: {species.hair_colors}\n" +
                                     $"Skin Colors: {species.skin_colors}\n" +
                                     $"Language: {species.language}\n" +
                                     $"Homeworld: {species.homeworld}\n" +
                                     $"Films: {string.Join(", ", species.films)}\n" +
                                     $"People: {string.Join(", ", species.people)}\n" +
                                     $"URL: {species.url}\n" +
                                     $"Created: {species.created.ToString("yyyy-MM-dd HH:mm:ss")}\n" +
                                     $"Edited: {species.edited.ToString("yyyy-MM-dd HH:mm:ss")}";

                    lblInfo.Text = speciesInfo;
                }
                else
                {
                    MessageBox.Show("Please enter a species ID between 1 and 37");
                }

            }
            else
            {
                MessageBox.Show("Please enter a species ID");
            }

        }

        private async void GetAllSpecies_btn_Click(object sender, EventArgs e)
        {
            AllSpecies allSpecies = await JSONHelper.GetAllSpecies();

            if (allSpecies != null && allSpecies.results != null)
            {
             

                foreach (var species in allSpecies.results)
                {
                    lsbSpecies.Items.Add($"Name: {species.name}");
                    lsbSpecies.Items.Add($"Classification: {species.classification}");
                    lsbSpecies.Items.Add($"Designation: {species.designation}");
                    lsbSpecies.Items.Add($"Average Height: {species.average_height}");
                    lsbSpecies.Items.Add($"Average Lifespan: {species.average_lifespan}");
                    lsbSpecies.Items.Add($"Eye Colors: {species.eye_colors}");
                    lsbSpecies.Items.Add($"Hair Colors: {species.hair_colors}");
                    lsbSpecies.Items.Add($"Skin Colors: {species.skin_colors}");
                    lsbSpecies.Items.Add($"Language: {species.language}");
                    lsbSpecies.Items.Add($"Homeworld: {species.homeworld}");
                    lsbSpecies.Items.Add($"Films: {string.Join(", ", species.films)}");
                    lsbSpecies.Items.Add($"People: {string.Join(", ", species.people)}");
                    lsbSpecies.Items.Add($"URL: {species.url}");
                    lsbSpecies.Items.Add($"Created: {species.created.ToString("yyyy-MM-dd HH:mm:ss")}");
                    lsbSpecies.Items.Add($"Edited: {species.edited.ToString("yyyy-MM-dd HH:mm:ss")}");

                    lsbSpecies.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show("No species found.");
            }
        }
    }
}
