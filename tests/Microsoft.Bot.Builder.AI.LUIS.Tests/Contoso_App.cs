﻿// <auto-generated>
// Code generated by LUISGen ..\..\..\..\LUISGenTest\Contoso App.json -cs Microsoft.Bot.Builder.Ai.Luis.Tests.Contoso_App -o ..\..\..\..\LUISGenTest
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
namespace Microsoft.Bot.Builder.AI.Luis.Tests
{
    public class Contoso_App: Microsoft.Bot.Builder.IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            Cancel, 
            Delivery, 
            EntityTests, 
            Greeting, 
            Help, 
            None, 
            search, 
            SpecifyName, 
            Travel, 
            Weather_GetForecast
        };
        public Dictionary<Intent, Microsoft.Bot.Builder.IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] Name;
            public string[] State;
            public string[] Weather_Location;
            public string[] City;
            public string[] To;
            public string[] From;

            // Built-in entities
            public Microsoft.Bot.Builder.AI.Luis.Age[] age;
            public Microsoft.Bot.Builder.AI.Luis.DateTimeSpec[] datetime;
            public Microsoft.Bot.Builder.AI.Luis.Dimension[] dimension;
            public string[] email;
            public Microsoft.Bot.Builder.AI.Luis.Money[] money;
            public double[] number;
            public double[] ordinal;
            public double[] percentage;
            public string[] phonenumber;
            public Microsoft.Bot.Builder.AI.Luis.Temperature[] temperature;
            public string[] url;

            // Lists
            public string[][] Airline;

            // Regex entities
            public string[] Part;

            // Pattern.any
            public string[] person;
            public string[] subject;
            public string[] extra;

            // Composites
            public class _InstanceAddress
            {
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] number;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] State;
            }
            public class AddressClass
            {
                public double[] number;
                public string[] State;
                [JsonProperty("$instance")]
                public _InstanceAddress _instance;
            }
            public AddressClass[] Address;

            public class _InstanceComposite1
            {
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] age;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] datetime;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] dimension;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] email;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] money;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] number;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] ordinal;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] percentage;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] phonenumber;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] temperature;
            }
            public class Composite1Class
            {
                public Microsoft.Bot.Builder.AI.Luis.Age[] age;
                public Microsoft.Bot.Builder.AI.Luis.DateTimeSpec[] datetime;
                public Microsoft.Bot.Builder.AI.Luis.Dimension[] dimension;
                public string[] email;
                public Microsoft.Bot.Builder.AI.Luis.Money[] money;
                public double[] number;
                public double[] ordinal;
                public double[] percentage;
                public string[] phonenumber;
                public Microsoft.Bot.Builder.AI.Luis.Temperature[] temperature;
                [JsonProperty("$instance")]
                public _InstanceComposite1 _instance;
            }
            public Composite1Class[] Composite1;

            public class _InstanceComposite2
            {
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] Airline;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] City;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] url;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] From;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] To;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] Weather_Location;
            }
            public class Composite2Class
            {
                public string[][] Airline;
                public string[] City;
                public string[] url;
                public string[] From;
                public string[] To;
                public string[] Weather_Location;
                [JsonProperty("$instance")]
                public _InstanceComposite2 _instance;
            }
            public Composite2Class[] Composite2;

            // Instance
            public class _Instance
            {
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] Name;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] State;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] Weather_Location;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] City;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] To;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] From;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] age;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] datetime;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] dimension;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] email;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] money;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] number;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] ordinal;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] percentage;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] phonenumber;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] temperature;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] url;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] Airline;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] Part;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] person;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] subject;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] extra;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] Address;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] Composite1;
                public Microsoft.Bot.Builder.AI.Luis.InstanceData[] Composite2;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<Contoso_App>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score.Value;
                }
            }
            return (maxIntent, max);
        }
    }
}