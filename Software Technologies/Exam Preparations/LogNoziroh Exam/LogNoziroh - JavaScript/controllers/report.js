const Report = require('../models/Report');

module.exports = {
    index: (req, res) => {
        Report.find().then(reports => {
            return res.render('report/index', {'reports': reports});
        }).catch(err => {
            return res.send("error");
        });
    },
    createGet: (req, res) => {
        res.render('report/create');
    },
    createPost: (req, res) => {
        let report = req.body;
        Report.create(report).then(report => {
            res.redirect("/");
        }).catch(err => {
            film.error = 'Cannot create film.';
            res.render('report/create', report);
        });
    },
    detailsGet: (req, res) => {
        let reportId = req.params.id;
        Report.findById(reportId).then(report => {
            if (report) {
                return res.render('report/details', report);
            }
            else {
                return res.redirect('/');
            }
        }).catch(err => res.redirect('/'));
    },
    deleteGet: (req, res) => {
        let reportId = req.params.id;
        Report.findById(reportId).then(report => {
            if (report) {
                return res.render('report/delete', report);
            }
            else {
                return res.redirect('/');
            }
        }).catch(err => res.redirect('/'));
    },
    deletePost: (req, res) => {
        let reportId = req.params.id;
        Report.findByIdAndRemove(reportId).then(report => {
            res.redirect('/');
        }).catch(err => res.redirect('/'));
    }
};