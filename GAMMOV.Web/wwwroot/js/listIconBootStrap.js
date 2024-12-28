document.addEventListener('DOMContentLoaded', function () {
    const link = document.createElement('link');
    link.rel = 'stylesheet';
    link.href = "/css/bootstrap-icons.css";
    document.head.appendChild(link);

    // بارگذاری CSS
    link.onload = function () {
        console.log('CSS loaded successfully');

        const iconList = document.getElementById('iconList');
        const iconClasses = [];
        const allStylesheets = document.styleSheets;

        Array.from(allStylesheets).forEach(sheet => {
            try {
                Array.from(sheet.rules || sheet.cssRules).forEach(rule => {
                    if (rule.selectorText && rule.selectorText.startsWith('.bi-')) {
                        const className = rule.selectorText.substring(1).split('::')[0];
                        iconClasses.push(className);
                    }
                });
            } catch (e) {
                console.error("Error reading stylesheet: ", e);
            }
        });

        const uniqueIconClasses = [...new Set(iconClasses)];
        iconList.innerHTML = ''; // Clear the list first

        uniqueIconClasses.forEach(icon => {
            const iconElement = document.createElement('div');
            iconElement.classList.add('col-3', 'text-center', 'icon-item'); // Added icon-item class
            iconElement.innerHTML = `<i class="bi ${icon} fs-2"></i><p>${icon.replace('bi-', '').replace('-', ' ')}</p>`;
            iconList.appendChild(iconElement);
        });
    };

    let selectedIconElement = null;

    // Listener for icon selection
    document.getElementById('iconList').addEventListener('click', function (e) {
        const target = e.target.closest('.icon-item'); // Use closest to find the .icon-item parent
        if (target) {
            const iconTag = target.querySelector('i.bi'); // Find the <i> element within the clicked .icon-item
            if (iconTag) {
                if (selectedIconElement) {
                    selectedIconElement.classList.remove('icon-selected');
                }
                target.classList.add('icon-selected');
                selectedIconElement = target;
            }
        }
    });

    document.getElementById('selectIconBtn').addEventListener('click', function () {
        if (selectedIconElement) {
            const iconClass = selectedIconElement.querySelector('i').className.split(' ')[1]; // Get only the second class which is the icon name
            document.getElementById('selectedIconInput').value = iconClass;
            $('#iconPickerModal').modal('hide'); // Close modal
        }
    });
});
