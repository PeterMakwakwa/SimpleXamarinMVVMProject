﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SimpleTest.Model;

namespace SimpleTest.Services
{
    public class PeopleDataservice : IPeopleDataService
    {
        private readonly string URlPeople = "https://techtestapi.azurewebsites.net/api/People";

        public async Task DeletePerson(int id)
        {
            try
            {
                var httpclient = new HttpClient();
                var response = await httpclient.DeleteAsync(URlPeople + "/" + id);
            }
            catch (Exception)
            {

            }
        }

        public async Task<List<Person>> GetPeople()
        {
            List<Person> tempEmployeeList = new List<Person>();
            try
            {
                var httpclient = new HttpClient();
                var json = await httpclient.GetStringAsync(URlPeople);
                var peopleList = JsonConvert.DeserializeObject<List<Person>>(json);
                return peopleList;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task PostPerson(Person person)
        {
            try
            {
                var httpclient = new HttpClient();
                var json = JsonConvert.SerializeObject(person);
                StringContent content = new StringContent(json);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var results = await httpclient.PostAsync(URlPeople, content);

            }
            catch (Exception)
            {
            }
        }

        public async Task PutPerson(int id, Person person)
        {
            try
            {
                var httpclient = new HttpClient();
                var json = JsonConvert.SerializeObject(person);
                StringContent content = new StringContent(json);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                var results = await httpclient.PutAsync(URlPeople + "/" + id, content);

            }
            catch (Exception)
            {
            }
        }

        public async Task<Person> Search(int ID)
        {
            Person PeopleSearch = new Person();
            try
            {
                var httpclient = new HttpClient();
                var json = await httpclient.GetStringAsync(URlPeople + "/" + ID);
                var peopleList = JsonConvert.DeserializeObject<Person>(json);
                return PeopleSearch;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
