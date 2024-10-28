import AddContact from './AddContact/AddContact';
import ViewContacts from './ViewContacts/ViewContacts';
import './Contacts.css'

function Contacts(args) {
    const { index } = args;

    return (<div className="contacts">
        {
            index == 0
            && <AddContact/>
        }
        {
            index == 1
            && <ViewContacts/>
        }
    </div>)
}

export default Contacts;