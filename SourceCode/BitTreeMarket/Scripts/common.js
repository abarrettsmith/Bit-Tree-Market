    var CartApp = CartApp || {};
    
    CartApp.Product = function (item) {
        var self = this;
        self.id = item.Id;
        self.name = item.Name;
        self.category = item.Category;
        self.quantity = ko.observable(item.Quantity);
        self.price = item.Price;
        self.selectedQuantity = ko.observable(item.SelectedQuantity);
    };
    
    CartApp.Order = function(item) {
        var self = this;
        self.id = item.Id;
        self.approved = ko.observable(item.Approved);
        self.customerName = item.CustomerName;
        self.orderTotal = item.OrderTotal;
        self.products = [];
        $.each(item.Products, function(idx, product) {
            self.products.push(new CartApp.Product(product));
        });
    };