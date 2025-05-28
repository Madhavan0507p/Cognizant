// 1. Basics & Setup
console.log("Welcome to the Community Portal");
window.onload = () => alert("Page fully loaded");

// 2. Syntax, Data Types & Operators
const eventName = "Spring Festival";
const eventDate = "2025-06-15";
let seatsAvailable = 50;
console.log(`Event: ${eventName} on ${eventDate} - Seats: ${seatsAvailable}`);
seatsAvailable--;
console.log(`Seats left: ${seatsAvailable}`);

// 5. Objects and Prototypes (before other logic)
class Event {
  constructor(name, date, seats, category) {
    this.name = name;
    this.date = date;
    this.seats = seats;
    this.category = category || "General";
  }
}
Event.prototype.checkAvailability = function () {
  return this.seats > 0;
};
const eventsList = [
  new Event("Spring Festival", "2025-06-15", 10, "Music"),
  new Event("Winter Gala", "2024-12-10", 0, "Workshop"),
  new Event("Summer Workshop", "2025-07-05", 20, "Workshop"),
  new Event("Jazz Night", "2025-08-12", 15, "Music"),
  new Event("Tech Meetup", "2025-09-10", 30, "Sports"),
  new Event("Art Exhibition", "2025-10-15", 25, "Workshop"),
];

function isUpcoming(date) {
  return new Date(date) > new Date();
}

// 3. Conditionals, Loops, Error Handling
function displayValidEvents(events) {
  return events.filter(e => isUpcoming(e.date) && e.checkAvailability());
}

// 4. Functions, Scope, Closures, HOFs
function addEvent(events, newEvent) {
  events.push(newEvent);
}

function registerUser(event) {
  try {
    if (!event.checkAvailability()) throw new Error("No seats available");
    event.seats--;
    return "Registration successful";
  } catch (e) {
    return e.message;
  }
}

function registrationTracker() {
  let count = 0;
  return function () {
    count++;
    return count;
  };
}
const trackMusicRegs = registrationTracker();

function filterEventsByCategory(events, category, callback) {
  const filtered = category ? events.filter(e => e.category === category) : events;
  callback(filtered);
}

// 6 & 7. Arrays, Methods & DOM Manipulation
const eventsContainer = document.querySelector('#eventsContainer');
const eventSelect = document.querySelector('select[name="event"]');
const categoryFilter = document.getElementById('categoryFilter');

function renderEvents(events) {
  eventsContainer.innerHTML = '';
  eventSelect.innerHTML = '<option value="">Select event</option>';

  events.forEach(event => {

    const card = document.createElement('div');
    card.className = 'event-card';
    card.textContent = `${event.name} - ${event.date} - Seats: ${event.seats}`;
    eventsContainer.appendChild(card);

    if (event.checkAvailability()) {
      const option = document.createElement('option');
      option.value = event.name;
      option.textContent = event.name;
      eventSelect.appendChild(option);
    }
  });
}

// 8. Event Handling
categoryFilter.onchange = () => {
  const selected = categoryFilter.value;
  filterEventsByCategory(displayValidEvents(eventsList), selected, renderEvents);
};

document.getElementById('registrationForm').addEventListener('submit', function (e) {
  e.preventDefault();
  const formMessage = document.getElementById('formMessage');
  const name = this.elements['name'].value.trim();
  const email = this.elements['email'].value.trim();
  const eventName = this.elements['event'].value;

  if (!name || !email || !eventName) {
    formMessage.innerHTML = '<p class="error">Please fill all fields</p>';
    return;
  }

  const eventObj = eventsList.find(ev => ev.name === eventName);
  if (!eventObj) {
    formMessage.innerHTML = '<p class="error">Selected event not found.</p>';
    return;
  }

  const result = registerUser(eventObj);
  formMessage.textContent = result;
  renderEvents(displayValidEvents(eventsList));  // Update UI after registration
  this.reset();
});

document.addEventListener('keydown', e => {
  if (e.key === 'Enter') {
    const query = prompt("Enter event name to search:");
    if (!query) return;
    const found = eventsList.find(ev => ev.name.toLowerCase().includes(query.toLowerCase()));
    alert(found ? `Found: ${found.name}` : "No event found");
  }
});

// 9. Async JS, Promises, Async/Await & Loading Spinner
const loadingSpinner = document.getElementById('loadingSpinner');
const mockApi = "https://jsonplaceholder.typicode.com/posts";

async function fetchEventsAsync() {
  try {
    loadingSpinner.style.display = 'inline';
    const res = await fetch(mockApi);
    const data = await res.json();
    loadingSpinner.style.display = 'none';
    console.log('Async fetched data:', data.slice(0, 3));
  } catch (err) {
    loadingSpinner.style.display = 'none';
    console.error('Async fetch error:', err);
  }
}
fetchEventsAsync();

// 10. Modern JS Features
function greetUser(name = "Guest") {
  console.log(`Hello, ${name}!`);
}
const { name: sampleName, date: sampleDate } = eventsList[0];
const eventsCopy = [...eventsList];
greetUser(sampleName);

// 12. AJAX & Fetch API to simulate POST registration
function submitRegistration(data) {
  const formMessage = document.getElementById('formMessage');
  formMessage.textContent = "Submitting registration...";
  setTimeout(() => {
    fetch('https://jsonplaceholder.typicode.com/posts', {
      method: 'POST',
      body: JSON.stringify(data),
      headers: { 'Content-Type': 'application/json' },
    })
      .then(res => {
        if (!res.ok) throw new Error("Network error");
        return res.json();
      })
      .then(json => {
        formMessage.textContent = "Registration successful!";
        console.log("Server response:", json);
      })
      .catch(err => {
        formMessage.textContent = "Registration failed. Try again.";
        console.error(err);
      });
  }, 1000); 
}

renderEvents(displayValidEvents(eventsList));
