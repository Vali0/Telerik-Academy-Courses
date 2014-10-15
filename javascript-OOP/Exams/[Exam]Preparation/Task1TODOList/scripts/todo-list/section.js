define(function () {
    var Section = (function () {
        function Section(title) {
            this._title = title;
            this._items = [];
        }

        Section.prototype.add = function (item) {
            this._items.push(item);
        }

        Section.prototype.getData = function(){
            var dataItems = [];

            for (var i = 0; i < this._items.length; i++) {
                dataItems.push(this._items[i].getData());
            }

            return {
                title: this._title,
                items: dataItems
            }
        }

        return Section;
    }());

    return Section;
});