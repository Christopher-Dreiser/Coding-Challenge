import './AddContact.css';
import { useState, useEffect } from 'react';

function AddContact() {
    const [firstName, setFirstName] = useState("");
    const [lastName, setLastName] = useState("");
    const [email, setEmail] = useState("");
    const [isSubmitted, setIsSubmitted] = useState(false);
    const [errorMessages, setErrorMessages] = useState([]);

    useEffect(() => {
        if (firstName.length + lastName.length + email.length != 0) {
            setIsSubmitted(false);
        }
    }, [firstName, lastName, email])

    function submit(e) {
        e.preventDefault();
        let contact = { firstName, lastName, email };
        fetch("/Contacts", {
            method: "post",
            headers: {
                "Accept": "application/json",
                "Content-Type": "application/json"
            },
            body: JSON.stringify(contact),
        }).then(() => {
            setFirstName("");
            setLastName("");
            setEmail("");
            setIsSubmitted(true);
        }).catch((error) => {
            errorMessages([error])
        });
    }


    return (
        <form className={"add-contact-page" + (isSubmitted ? " is-submitted" : "")} onSubmit={submit}>
            <div className="submit-message">Contact successfully submitted!</div>
            <div><label>Email: </label><input required onInvalid={f => f.target.setCustomValidity("Email must be a valid email address.")} onInput={F => F.target.setCustomValidity('')} value={email} onChange={(e) => setEmail(e.target.value)} type="email"/></div>
            <div><label>First Name: </label><input required onInvalid={f => f.target.setCustomValidity("First Name cannot be empty")} onInput={F => F.target.setCustomValidity('')} value={firstName} onChange={(e) => setFirstName(e.target.value)} type="text"/></div>
            <div><label>Last Name: </label><input required onInvalid={f => f.target.setCustomValidity("Last Name cannot be empty")} onInput={F => F.target.setCustomValidity('')} value={lastName} onChange={(e) => setLastName(e.target.value)} type="text"/></div>
            <button type="submit">Submit</button>
        </form>
    );
}

export default AddContact;