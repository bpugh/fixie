﻿using System.Reflection;

namespace Fixie
{
    public class DefaultConvention : Convention
    {
        public DefaultConvention()
        {
            Fixtures
                .NameEndsWith("Tests")
                .HasDefaultConstructor();

            Cases
                .Visibility(BindingFlags.Public | BindingFlags.Instance)
                .Where(method => method.Void() || method.Async())
                .ZeroParameters();
        }
    }
}