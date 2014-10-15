define(function () {
    var Item = (function () {
        function Item(type, name, price) {
            if (type !== 'accessory' &&
                type !== 'smart-phone' &&
                type !== 'notebook' &&
                type !== 'pc' &&
                type !== 'tablet') {
                throw { message: 'Type of the item must be accessory, smart-phone, notepbook, pc, or tablet!' };
            }

            if (name.length < 6 || name.length > 40) {
                throw { message: 'Name length of the item must be between 6 and 40 symbols symbols' };
            }

            this.type = type;
            this.name = name;
            this.price = price;
        }

        return Item;
    }());

    return Item;
});