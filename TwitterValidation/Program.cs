using TwitterValidation;


string text = Console.ReadLine();


/*string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas a risus auctor, " +
    "tempor tortor id, convallis dui. Nulla sit amet mi arcu. Proin sit amet aliquam nulla. Pelle" +
    "ntesque finibus, lorem eget scelerisque auctor, mi est tristique quam, ac tincidunt odio urn" +
    "a vitae mi. Mauris vel malesuada ante. Mauris et quam vitae quam lobortis viverra sit amet a" +
    "c ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae" +
    "; Vivamus tincidunt tincidunt dolor, non consequat nulla venenatis vitae. Fusce sed tortor e" +
    "t lorem porttitor vehicula. Vestibulum risus augue, venenatis ac volutpat non, sollicitudin " +
    "ac magna. Praesent a ex vel dolor fringilla mollis nec vel tellus. Quisque quis lorem elit. " +
    "Ut posuere cursus nisi nec varius. Donec rhoncus turpis eget lectus imperdiet elementum. Sus" +
    "pendisse cursus, nunc vitae faucibus sagittis, orci nisi rutrum nulla, at tincidunt lacus lo" +
    "rem eget magna.";*/


var preprocessors = new List<TextPreprocessor>();
preprocessors.Add(new GreetingPreprocessor());
preprocessors.Add(new ProfanityPreprocessor());
preprocessors.Add(new LengthPreprocessor());


preprocessors.ForEach(p => p.PrepareText(ref text)); // validate text by passing it through each preprocessor



Console.WriteLine(text);