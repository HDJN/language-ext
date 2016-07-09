﻿using Xunit;
using static LanguageExt.Prelude;
using static LanguageExt.TypeClass.Prelude;
using LanguageExt;
using LanguageExt.TypeClass;

namespace LanguageExtTests
{
    public class Divisible
    {
        [Fact]
        public void OptionalNumericDivide()
        {
            var x = Some(20);
            var y = Some(10);
            var z = divide<TInteger, int>(x, y);

            Assert.True(z == 2);
        }
    }
}
