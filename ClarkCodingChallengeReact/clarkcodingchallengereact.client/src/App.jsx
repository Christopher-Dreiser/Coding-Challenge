import { useEffect, useState } from 'react';
import Contacts from './Contacts/Contacts'
import './App.css';

function App() {
    const [tabIndex, setTabIndex] = useState(0);

    return (
        <html>
            <head>
                <meta charSet="utf-8" />
                <meta name="viewport" content="width=device-width, initial-scale=1.0" />
                <title>@ViewData["Title"] - ClarkCodingChallenge</title>

                {!process.env.NODE_ENV || process.env.NODE_ENV === 'development'
                    ? <div>
                        <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.css" />
                    </div>
                    : <div>
                        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.min.css"
                            asp-fallback-href="~/lib/bootstrap/dist/css/bootstrap.min.css"
                            asp-fallback-test-class="sr-only" asp-fallback-test-property="position" asp-fallback-test-value="absolute"
                            crossOrigin="anonymous"
                            integrity="sha256-eSi1q2PG6J7g7ib17yAaWMcrr5GrtohYChqibrV7PBE=" />
                    </div>
                }
                <link rel="stylesheet" href="~/css/site.css" />
            </head>
            <body>
                <header>
                    <nav className="navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3">
                        <div className="container">
                            <a className="navbar-brand" asp-area="" asp-controller="Home" asp-action="Index">Clark Coding Challenge</a>
                            <button className="navbar-toggler" type="button" data-toggle="collapse" data-target=".navbar-collapse" aria-controls="navbarSupportedContent"
                                aria-expanded="false" aria-label="Toggle navigation">
                                <span className="navbar-toggler-icon"></span>
                            </button>
                            <div className="navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse">
                                { /* TODO: Replace with React router for production */}
                                <ul className="navbar-nav flex-grow-1">
                                    <li className="nav-item" onClick={() => setTabIndex(0)}>
                                        <a className="nav-link text-dark">Add Contact</a>
                                    </li>
                                    <li className="nav-item" onClick={() => setTabIndex(1)}>
                                        <a className="nav-link text-dark">View Contacts</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </nav>
                </header>
                <div className="container">
                    { /* TODO: Replace with React router for production */ }
                    <Contacts index={tabIndex}/>
                </div>

                <environment include="Development">
                    <script src="~/lib/jquery/dist/jquery.js"></script>
                    <script src="~/lib/bootstrap/dist/js/bootstrap.bundle.js"></script>
                </environment>
                <environment exclude="Development">
                    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"
                        asp-fallback-src="~/lib/jquery/dist/jquery.min.js"
                        asp-fallback-src="~/lib/jquery/dist/jquery.min.js"
                        asp-fallback-test="window.jQuery"
                        crossOrigin="anonymous"
                        integrity="sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=">
                    </script>
                    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/js/bootstrap.bundle.min.js"
                        asp-fallback-src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"
                        asp-fallback-test="window.jQuery && window.jQuery.fn && window.jQuery.fn.modal"
                        crossOrigin="anonymous"
                        integrity="sha256-E/V4cWE4qvAeO5MOhjtGtqDzPndRO1LBk8lJ/PR7CA4=">
                    </script>
                </environment>

                <footer className="border-top footer text-muted">
                    <div className="container">
                        &copy; 2019 - Clark Coding Challenge
                    </div>
                </footer>
                <script src="~/js/site.js" asp-append-version="true"></script>
            </body>
        </html>
    );
}

export default App;