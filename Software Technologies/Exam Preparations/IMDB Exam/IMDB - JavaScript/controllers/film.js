const Film = require('../models/Film');

module.exports = {
	index: (req, res) => {
        Film.find().then(films => {
            res.render('film/index', {'films': films});
        });
	},
	createGet: (req, res) => {
        res.render('film/create');
	},
	createPost: (req, res) => {
        let film = req.body;
        Film.create(film).then(film => {
            res.redirect("/");
        });
	},
	editGet: (req, res) => {
        let filmId = req.params.id;
        Film.findById(filmId).then(film => {
            if (film) {
                res.render('film/edit', film);
            }
            else {
                res.redirect('/');
            }
        });
	},
	editPost: (req, res) => {
        let filmId = req.params.id;
        let film = req.body;

        Film.findByIdAndUpdate(filmId, film).then(film => {
            res.redirect("/");
        });
	},
	deleteGet: (req, res) => {
        let filmId = req.params.id;
        Film.findById(filmId).then(film => {
            if (film) {
                res.render('film/delete', film);
            }
            else {
                res.redirect('/');
            }
        });
	},
	deletePost: (req, res) => {
        let filmId = req.params.id;

        Film.findByIdAndRemove(filmId).then(film => {
            res.redirect("/");
        });
	}
};