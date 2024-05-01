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
    public partial class StarWarsInfo : Form
    {
        public StarWarsInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // <summary>
        // Gets information related to a planet specified by a users inputed id
        // </summary>
        private async void GetPlanet_Click(object sender, EventArgs e)
        {
            string planetID = txbID.Text;

            // Ensure the user inputed an intege
            if (int.TryParse(planetID, out int id))
            {
                // Makes sure that the user inputed an existing planet
                if (id >= 1 && id <= 61)
                {
                    Planet planet = await JSONHelper.GetPlanet(planetID);

                    //Concatenates planet info into a string
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

        // <summary>
        // Gets information related to a person specified by a users inputed id
        // </summary>
      
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

                                // Turns the long url of starhips into their names
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

  
        // <summary>    
        // Grab every starship is a list of starship urls
        // </summary>
        private async Task<string> GetStarshipsNames(List<string> starshipUrls)
        {
            List<string> starshipNames = new List<string>();

            // For every url in the list it grabs a name and adds it to starshipNames
            foreach (string url in starshipUrls) 
            {

                Starship starship = await JSONHelper.GetStarshipName(url);
                starshipNames.Add(starship.name);
            }

            // Return the list of starship names converted from urls
            return string.Join(", ", starshipNames);
        }

        // <summary>
        // Gets information related to a species specified by a users inputed id
        // </summary>
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

        // <summary>
        // Gets all information about Star Wars Species and displays them in a listbox
        // </summary>
        private async void GetAllSpecies_btn_Click(object sender, EventArgs e)
        {
            AllSpecies allSpecies = await JSONHelper.GetAllSpecies();

            if (allSpecies != null && allSpecies.results != null)
            {
             
                // Repeats over every species and add information to a test box
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

        // <summary>
        // Gets all information about Star Wars films and displays them 
        // </summary>
        private async void GetFilmInfo_btn_Click(object sender, EventArgs e)
        {
            string movieID = txbFilmID.Text;

            if (int.TryParse(movieID, out int id))
            {
                if (id >= 1 && id <= 7)
                {
                    Films film = await JSONHelper.GetFilms(movieID);


                    string filmInfo = $"Title: {film.title}\n" +
                                   $"Episode ID: {film.episode_id}\n" +
                                   $"Opening Crawl: {film.opening_crawl}\n" +
                                   $"Director: {film.director}\n" +
                                   $"Producer(s): {film.producer}\n" +
                                   $"Release Date: {film.release_date.ToString("yyyy-MM-dd")}\n" +
                                   $"Species: {string.Join(", ", film.species)}\n" +
                                   $"Starships: {await GetStarshipsNames(film.starships)}\n" +
                                   $"Vehicles: {string.Join(", ", film.vehicles)}\n" +
                                   $"Characters: {string.Join(", ", film.characters)}\n" +
                                   $"Planets: {string.Join(", ", film.planets)}\n" +
                                   $"URL: {film.url}\n" +
                                   $"Created: {film.created}\n" +
                                   $"Edited: {film.edited}";

                    lblInfo.Text = filmInfo;
                }
                else
                {
                    MessageBox.Show("Please enter a film ID between 1 and 7");
                }

            }
            else
            {
                MessageBox.Show("Please enter a film ID");
            }

        }

        private void txbFilmID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // <summary>
        // Gets all information about Star Wars starship and compares the speed to eachother outputting which is faster 
        // </summary>
        private async void compareStarship_btn_Click(object sender, EventArgs e)
        {
            string starShipOneID = starshipOne_txb.Text;
            string starShipTwoID = starshipTwo_txb.Text;
        
            if (int.TryParse(starShipOneID, out int id1) && int.TryParse(starShipTwoID, out int id2))
            {
                if (id1 >= 1 && id1 <= 37 && id2 >= 1 && id2 <= 37)
                {
                    Starship starship1 = await JSONHelper.GetStarship(starShipOneID);
                    Starship starship2 = await JSONHelper.GetStarship(starShipTwoID);

                    int speed1, speed2;

                    // If can be converted to int then it compares otherwise print and error message because max speed isn't avaliable
                    if (int.TryParse(starship1.max_atmosphering_speed, out speed1) &&
                        int.TryParse(starship2.max_atmosphering_speed, out speed2))
                    {
                        string result;
                        if (speed1 > speed2)
                        {
                            result = $"{starship1.name} is faster than {starship2.name}";
                        }
                        else if (speed1 < speed2)
                        {
                            result = $"{starship2.name} is faster than {starship1.name}";
                        }
                        else
                        {
                            result = $"{starship1.name} and {starship2.name} have the same maximum speed";
                        }
                        resultLbl.Text = result;
                    }
                    else
                    {
                        resultLbl.Text = "One or both starships have invalid maximum speed";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a starship ID between 1 and 37");
                }

            }
            else
            {
                MessageBox.Show("Please enter a starship ID");
            }
        }
    }
}
