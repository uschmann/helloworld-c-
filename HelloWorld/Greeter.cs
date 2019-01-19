using HelloWorld.Output;
using System;

namespace HelloWorld
{
    class Greeter
    {
        private ILogger mLogger;

        private SalutationBuilder mSalutationBuilder;

        public Greeter(ILogger logger, SalutationBuilder salutationBuilder)
        {
            mLogger = logger;
            mSalutationBuilder = salutationBuilder;
        }

        public void sayHi(String name)
        {
            String text = mSalutationBuilder.build(name);
            mLogger.Print(text);
        }

    }
}
