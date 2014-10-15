define(function () {
    var Store = (function () {
        // Hidden members
        function sortItemsBy(sortBy) {
            var sortedItems = this;
            // or this.slice(0) // Doesn't say how to return data
            sortedItems.sort(sortBy);

            return sortedItems;
        }

        function compareAlphabetically(first, second) {
            var firstName = first.name.toLowerCase(),
                secondName = second.name.toLowerCase();

            if (firstName < secondName) {
                return -1;
            }
            if (firstName > secondName) {
                return 1;
            }
            return 0;
        }

        function comparePrice(first, second) {
            return first.price - second.price;
        }

        // Exposed members
        function Store(name) {
            if (name.length < 6 || name.length > 30) {
                throw { message: 'Name length of storàãe must be between 6 and 30 symbols symbols' };
            }
            this.name = name;
            this._items = [];
        }

        Store.prototype.addItem = function (item) {
            this._items.push(item);

            return this; // provide chaning
        }

        Store.prototype.getAll = function () {
            return sortItemsBy.call(this._items, compareAlphabetically);
        }

        Store.prototype.getSmartPhones = function () {
            var smartPhones = this._items.filter(function (element) {
                return element.type === 'smart-phone';
            });

            return sortItemsBy.call(smartPhones, compareAlphabetically);
        }

        Store.prototype.getMobiles = function () {
            var mobiles = this._items.filter(function (element) {
                return (element.type === 'smart-phone') || (element.type === 'tablet');
            });

            return sortItemsBy.call(mobiles, compareAlphabetically);
        }

        Store.prototype.getComputers = function () {
            var computers = this._items.filter(function (element) {
                return (element.type === 'pc') || (element.type === 'notebook');
            });

            return sortItemsBy.call(computers, compareAlphabetically);
        }

        Store.prototype.filterItemsByPrice = function (priceRange) {
            var priceRange = priceRange || {};
            priceRange.min = priceRange.min || 0;
            priceRange.max = priceRange.max || Number.POSITIVE_INFINITY;
            
            var filteredByPrice = this._items.filter(function (element) {
                return (element.price >= priceRange.min) && (element.price <= priceRange.max);
            });

            return sortItemsBy.call(filteredByPrice, comparePrice);
        }

        Store.prototype.filterItemsByType = function (filterType) {
            var filteredByType = this._items.filter(function (element) {
                return element.type === filterType;
            });

            return sortItemsBy.call(filteredByType, compareAlphabetically);
        }

        Store.prototype.filterItemsByName = function (partOfName) {
            var filteredByName = this._items.filter(function (element) {
                return element.name.toLowerCase().indexOf(partOfName) !== -1; // toLowerCase() searches case-insensitive
            });

            return sortItemsBy.call(filteredByName, compareAlphabetically);
        }

        Store.prototype.countItemsByType = function () {
            var groupedItems = {};

            for (var i = 0, len = this._items.length; i < len; i++) {
                // Creates a Object field if not have with default value 0 and adds one for the match.
                // If there is existing field it just get it and adds one more to the value pair
                groupedItems[this._items[i].type] = (groupedItems[this._items[i].type] || 0) + 1; 
            }
            
            return groupedItems;
        }

        return Store;
    }());

    return Store;
});