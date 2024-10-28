import { useState, useEffect } from "react";
import './ViewContacts.css'


function ViewContacts() {
    const [contacts, setContacts] = useState(null);
    // Populate contacts on render.
    useEffect(() => {
        fetch('/Contacts')
            .then(response => response.json())
            .then(data => setContacts(data));
    }, []);

    return (
        <div className="view-contacts-page">
            {
                contacts && contacts.some(() => true)
                    ? <ul className="contacts-list"> {
                        contacts.map((element) => 
                            <li className="contact-item">
                                <p>
                                    <b>{element.email}</b>
                                    <br />
                                    {element.firstName + " " + element.lastName}
                                </p>
                            </li>
                        )
                    }</ul>
                    : contacts ? <div>No data.</div> : <div>Loading</div>
            }
        </div>
    )
}

export default ViewContacts;