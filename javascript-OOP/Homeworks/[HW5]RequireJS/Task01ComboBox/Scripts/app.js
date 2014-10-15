(function () {
    require.config({
        paths: {
            'jquery': 'libs/jquery-2.1.1.min',
            'handlebars': 'libs/handlebars.min',
            'combobox': 'modules/combobox',
            'template': 'modules/templateGenerator'
        }
    });

    require(['template', 'jquery', 'combobox', 'test-data'], function (template, jquery, combobox, people) {
        var generator = new template('#person-template', people);
        var dropdown = generator.getDropdownDiv();
        $('#combo-box-container').comboBox(dropdown);
    });

}());