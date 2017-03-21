// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Extensions.Options.Tests
{
    public class FakeOptionsSetupA : ConfigureOptions<FakeOptions>
    {
        public FakeOptionsSetupA() : base(string.Empty, o => o.Message += "A")
        {
        }
    }

    public class FakeOptionsSetupB : ConfigureOptions<FakeOptions>
    {
        public FakeOptionsSetupB() : base(string.Empty, o => o.Message += "B")
        {
        }
    }

    public class FakeOptionsSetupC : ConfigureOptions<FakeOptions>
    {
        public FakeOptionsSetupC() : base(string.Empty, o => o.Message += "C")
        {
        }
    }
}
