﻿using System.Collections.Generic;

namespace PassionateHarpist.API.Models.DTO
{
    public class Response<T>
    {
        public List<T> Data { get; set; }
        public bool Success { get; set; }
        public Dictionary<string, List<string>> Errors { get; set; }

        public Response()
        {
            Errors = new Dictionary<string, List<string>>();
        }

        public void AddError(string key, string msg)
        {
            if (Errors.ContainsKey(key))
            {
                Errors[key].Add(msg);
            }
            else
            {
                Errors[key] = new List<string>();
                Errors[key].Add(msg);
            }
        }
    }
}
