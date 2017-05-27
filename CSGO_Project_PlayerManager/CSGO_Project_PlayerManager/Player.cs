/* Template: http://forums.dotnetfoundation.org/t/file-headers-and-copyright-statements/1276
 * Copyright (c) .NET Foundation. All rights reserved.  
 * Licensed under the MIT License. See LICENSE file in the project root for full license information.  
 * 
 * This is the official list of the CSGO_Project_PlayerManager project contributors.
 * Names of the original copyright holders (individuals or organizations)
 * should be listed with a '*' in the first column. People who have 
 * contributed from an organization can be listed under the organization
 * that actually holds the copyright for their contributions (see the 
 * Microsoft organization for an example). Those individuals should have
 * their names indented and be marked with a '-'
 * For use within CSGO Project
 * 
 * Developer
 * - Remus Jones
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;

namespace CSGO_Project_PlayerManager
{
    [XmlType("Player")]
    public class Player
    {

        public string portraitdir;
        public string name;
        public string currentTeam;
        public float accuracy;
        public float stamina;
        public int contractCost;

        // serialize this to the doc
        public void SerializePlayer(string xmlDir)
        {
            // we need to store the current contents of the file 
            // to doc, to rewrite it.
            List<Player> t = new List<Player>();
            t.Add(this);
            // store each player in the doc inside the list to reserialize
            try
            {
                using (var reader = new StreamReader(xmlDir))
                {
                    // deserializer
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<Player>),
                     new XmlRootAttribute("playerList"));
                    // add to our list
                    t.AddRange((List<Player>)deserializer.Deserialize(reader));
                }
            }
            // catch any exceptions if the file is empty (we dont care).
            catch (Exception err)
            { 
                // suppress exception.
            }


            // get the folder that the xml is in.
            string absolutedir = Path.GetDirectoryName(xmlDir);
            // check if the folder exists.
            if (!Directory.Exists(absolutedir + "\\Portraits"))
            {
                // if it doesn't create it
                Directory.CreateDirectory(absolutedir + "\\Portraits");
            }
            // add image next to the xml file
            System.IO.File.Copy(portraitdir, absolutedir + "\\Portraits\\" + name+currentTeam+".png");
            // add set the portraits directory to the new dir, this will be relevent to the xml file
            portraitdir = "Portraits\\" + name + currentTeam + ".png";
 

            // create a writer with the intent of overwriting the existing file
            using (var writer = new FileStream(xmlDir, FileMode.Create))
            {
                // create a new serializer
                XmlSerializer ser = new XmlSerializer(typeof(List<Player>),
                new XmlRootAttribute("playerList"));
                // serialize
                ser.Serialize(writer, t);
            }



        }

    }
}
