namespace DotNetScaffolder.Presentation.Console
{
    using System;
    using System.IO;
    using HandlebarsDotNet;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //             string source =
            // @"<div class=""entry"">
            //   <h1>{{title}}</h1>
            //   <div class=""body"">
            //     {{body}}
            //   </div>
            // </div>";

            HandlebarsBlockHelper _stringEqualityBlockHelper = (TextWriter output, HelperOptions options, dynamic context, object[] arguments) =>
            {
                if (arguments.Length != 2)
                {
                    throw new HandlebarsException("{{StringEqualityBlockHelper}} helper must have exactly two argument");
                }
                string left = arguments[0] as string;
                string right = arguments[1] as string;
                if (left == right)
                {
                    options.Template(output, null);
                }
                else
                {
                    options.Inverse(output, null);
                }
            };

            Handlebars.RegisterHelper("eq", _stringEqualityBlockHelper);

            string source =
            @"
                {{eq title 'My new post'}}
                True
                {{else}}
                false
                {{
                    /eq
                }}
            ";

            var template = Handlebars.Compile(source);

            var data = new
            {
                title = "My new post",
                body = "This is my first post!"
            };

            var result = template(data);
            Console.WriteLine(result);


            //             Handlebars.RegisterHelper("StringEqualityBlockHelper", _stringEqualityBlockHelper);
            // Dictionary<string, string> animals = new Dictionary<string, string>() {
            // 	{"Fluffy", "cat" },
            // 	{"Fido", "dog" },
            // 	{"Chewy", "hamster" }
            // };
            // string template = "{{#each @value}}The animal, {{@key}}, {{StringEqualityBlockHelper @value 'dog'}}is a dog{{else}}is not a dog{{/StringEqualityBlockHelper}}.\r\n{{/each}}";
            // Func<object, string> compiledTemplate = Handlebars.Compile(template);
            // string templateOutput = compiledTemplate(animals);
        }
    }
}
