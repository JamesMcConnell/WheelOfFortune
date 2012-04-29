$(function () {
    var playerViewModel = function (playerDto) {
        this.id = ko.observable();
        this.name = ko.observable();
        this.lettersGuessed = ko.observableArray();
        this.winnings = ko.observable();

        ko.mapping.fromJS(playerDto, {}, this);
    };

    var appViewModel = function () {
        var self = this;

        // hub stuff
        self.hub = $.connection.clientHub;
        self.hub.reportError = function (error) {
            $('#error').text(error);
            $('#error').fadeIn(1000, function () {
                $('#error').fadeOut(3000);
            });
        };

        // Methods
        self.init = function () {
            self.hub.currentPlayersRequest();
        }

        // Hub callbacks
        self.hub.gameStateResponse = function (result) {
            self.currentGameState(result)
        };

        self.hub.currentPlayersResponse = function (result) {
            var mappedPlayers = $.map(result, function (dtoPlayer) {
                return new playerViewModel(dtoPlayer);
            });

            self.players = mappedPlayers;
        };

        this.CheckGameState = function () {
            self.hub.gameStateRequest();
        };

        // Properties
        this.currentGameState = ko.observable('No State Acquired');
        this.players = ko.observableArray([
			new playerViewModel({ id: -1, name: '', lettersGuessed: new Array(), winnings: 0 }),
			new playerViewModel({ id: -1, name: '', lettersGuessed: new Array(), winnings: 0 }),
			new playerViewModel({ id: -1, name: '', lettersGuessed: new Array(), winnings: 0 })
		]);
    };

    var viewModel = new appViewModel();
    ko.applyBindings(viewModel);
    $.connection.hub.start(function () {
        viewModel.init();
        viewModel.hub.startConnection();
        self.notify = true;
    });
});