﻿using Saber.Database;
using Saber.Database.Models;
using Saber.Database.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services
{
    public class OneLinerService
    {
        private GenericProvider<OneLinerQuote> _provider;

        private readonly List<OneLinerQuote> Quotes;

        public OneLinerService(Db db)
        {
            _provider = new GenericProvider<OneLinerQuote>(db);

            Quotes = _provider.GetAll().ToList();
        }

        public OneLinerQuote GetRandomQuote(OneLinerSource? source = null)
            => Quotes.Where(x => source == null || x.Source == source).OrderBy(x => Helpers.Random.Next()).First();
        

        public OneLinerQuote FindQuote(string query, OneLinerSource? source = null)
        {
            var splitQuery = query.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // DbCtx.OneLiners where splitQuery intersects with Quote, order by most matches, 
            var results =
                Quotes
                .Where(x => source == null || x.Source == source)
                .OrderByDescending(x =>
                    splitQuery
                    .Intersect(
                        x.Quote.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    ).Count()
                );

            if (results.Count() == 0)
                return GetRandomQuote(source);

            var res = results.FirstOrDefault();

            if (res == null)
                return GetRandomQuote(source);

            return res;
        }
    }
}
