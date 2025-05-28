// 1. Page Load
function pageLoaded() {
  console.log("Welcome to the Community Portal");
  alert("Page fully loaded!");
  loadEvents();
  loadPreference();
}

// 2. Variables
const events = [
  { name: "Music Fest", date: "2025-06-10", seats: 5, type: "music" },
  { name: "Book Fair", date: "2025-06-15", seats: 0, type: "education" },
];

// 3. Display Valid Events
function loadEvents() {
  const now = new Date();
  const container = document.getElementById("eventContainer");
  container.innerHTML = "";
  events.forEach((ev, i) => {
    if (new Date(ev.date) > now && ev.seats > 0) {
      const card = document.createElement("div");
      card.className = "event-card highlight";
      card.innerHTML = `
        <h4>${ev.name}</h4>
        <p>Date: ${ev.date} | Seats: ${ev.seats}</p>
        <button onclick="register(${i})">Quick Register</button>
      `;
      container.appendChild(card);
    }
  });
}

// 4. Register Function
function register(index) {
  try {
    if (events[index].seats > 0) {
      events[index].seats--;
      alert(`Registered for ${events[index].name}`);
      loadEvents();
    } else {
      alert("No seats available.");
    }
  } catch (e) {
    alert("Error registering: " + e.message);
  }
}

// 5. Constructor + Prototype
function Event(name, date) {
  this.name = name;
  this.date = date;
}
Event.prototype.checkAvailability = function () {
  return "Available on " + this.date;
};
const e1 = new Event("Yoga Class", "2025-07-01");

// 6. Array Methods
const musicEvents = events.filter(e => e.type === "music");
const names = events.map(e => "Event: " + e.name);

// 7. Form Handling
document.getElementById("registerForm").addEventListener("submit", function (e) {
  e.preventDefault();
  const name = this.elements["name"].value;
  const email = this.elements["email"].value;
  const event = this.elements["event"].value;
  if (!event) return alert("Please choose an event.");
  document.getElementById("feedback").textContent = `${name}, you're registered for ${event}!`;

  // 12. AJAX Simulation
  postRegistration({ name, email, event });
});

// 8. Search Events
document.getElementById("searchInput").addEventListener("keydown", function (e) {
  const term = e.target.value.toLowerCase();
  const results = events.filter(ev => ev.name.toLowerCase().includes(term));
  console.log("Search results:", results);
});

// 9. Async Fetch Mock
async function fetchEvents() {
  document.getElementById("eventContainer").textContent = "Loading...";
  try {
    const res = await fetch("https://jsonplaceholder.typicode.com/posts");
    const data = await res.json();
    console.log("Mock events loaded", data.slice(0, 3));
  } catch (err) {
    console.error("Failed to fetch events:", err);
  }
}

// 10. Modern JS
const [firstEvent] = events;
const { name, date } = firstEvent;
const clone = [...events];

// 11. Save Preference
function savePreference(value) {
  localStorage.setItem("preferredEvent", value);
}
function loadPreference() {
  const pref = localStorage.getItem("preferredEvent");
  if (pref) document.querySelector("select[name='event']").value = pref;
}

// 12. AJAX Simulated Post
function postRegistration(data) {
  fetch("https://jsonplaceholder.typicode.com/posts", {
    method: "POST",
    body: JSON.stringify(data),
    headers: { "Content-Type": "application/json" },
  })
    .then(res => res.json())
    .then(data => alert("Registration sent!"))
    .catch(err => console.error(err));
}

// 13. Debugging Tip
console.log("Debug tip: Check the Console and Network tab in DevTools.");

// 14. jQuery Snippet (commented out)
// $('#registerBtn').click(() => alert("jQuery Clicked!"));

// Video Ready
function videoReady() {
  document.getElementById("videoStatus").textContent = "Video ready to play.";
}

// Nearby Events
function findNearby() {
  if (navigator.geolocation) {
    navigator.geolocation.getCurrentPosition(
      pos => {
        const coords = pos.coords;
        document.getElementById("locationInfo").textContent =
          `Latitude: ${coords.latitude}, Longitude: ${coords.longitude}`;
      },
      err => alert("Geolocation error: " + err.message),
      { enableHighAccuracy: true, timeout: 5000 }
    );
  } else {
    alert("Geolocation not supported");
  }
}

// Warn on page exit
window.onbeforeunload = function () {
  return "Are you sure you want to leave?";
};
