define(function () {
    var Container = (function () {
        function Container() {
            this._sections = [];
        }

        Container.prototype.add = function (section) {
            this._sections.push(section);
        }

        Container.prototype.getData = function () {
            var dataSections = [];
            
            for (var i = 0; i < this._sections.length; i++) {
                dataSections.push(this._sections[i].getData());
            }

            return dataSections;
        }

        return Container;
    }());

    return Container;
});