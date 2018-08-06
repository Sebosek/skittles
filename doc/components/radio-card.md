# Radio card component

<div class="skittles-components-sample">
    <label class="radio-card">
        <input type="radio" name="radio" checked />
        <div class="radio-card__control"></div>
        <div class="radio-card__content">
            <div class="skittles-components-card">
                <div class="skittles-components-card__icon">
                    <svg class="icon">
                        <use xlink:href="#flask" />
                    </svg>
                </div>
                <div class="skittles-components-card__title">Experimental</div>
            </div>
        </div>
    </label>
    <label class="radio-card">
        <input type="radio" name="radio" />
        <div class="radio-card__control"></div>
        <div class="radio-card__content">
            <div class="skittles-components-card">
                <div class="skittles-components-card__icon">
                    <svg class="icon">
                        <use xlink:href="#gamepad" />
                    </svg>
                </div>
                <div class="skittles-components-card__title">Playful</div>
            </div>
        </div>
    </label>
    <label class="radio-card">
        <input type="radio" name="radio" />
        <div class="radio-card__control"></div>
        <div class="radio-card__content">
            <div class="skittles-components-card">
                <div class="skittles-components-card__icon">
                    <svg class="icon">
                        <use xlink:href="#heart" />
                    </svg>
                </div>
                <div class="skittles-components-card__title">With love</div>
            </div>
        </div>
    </label>
    <label class="radio-card radio-card--disabled">
        <input type="radio" name="radio" />
        <div class="radio-card__control"></div>
        <div class="radio-card__content">
            <div class="skittles-components-card">
                <div class="skittles-components-card__icon skittles-components-card__icon--disabled">
                    <svg class="icon">
                        <use xlink:href="#close" />
                    </svg>
                </div>
                <div class="skittles-components-card__title">Disabled</div>
            </div>
        </div>
    </label>
</div>

```html
<label class="radio-card">
    <input type="radio" name="radio" checked />
    <div class="radio-card__control"></div>
    <div class="radio-card__content">
        <div class="skittles-components-card">
            <div class="skittles-components-card__icon">
                <svg class="icon">
                    <use xlink:href="#flask" />
                </svg>
            </div>
            <div class="skittles-components-card__title">Experimental</div>
        </div>
    </div>
</label>
<label class="radio-card">
    <input type="radio" name="radio" />
    <div class="radio-card__control"></div>
    <div class="radio-card__content">
        <div class="skittles-components-card">
            <div class="skittles-components-card__icon">
                <svg class="icon">
                    <use xlink:href="#gamepad" />
                </svg>
            </div>
            <div class="skittles-components-card__title">Playful</div>
        </div>
    </div>
</label>
<label class="radio-card">
    <input type="radio" name="radio" />
    <div class="radio-card__control"></div>
    <div class="radio-card__content">
        <div class="skittles-components-card">
            <div class="skittles-components-card__icon">
                <svg class="icon">
                    <use xlink:href="#heart" />
                </svg>
            </div>
            <div class="skittles-components-card__title">With love</div>
        </div>
    </div>
</label>
<label class="radio-card radio-card--disabled">
    <input type="radio" name="radio" />
    <div class="radio-card__control"></div>
    <div class="radio-card__content">
        <div class="skittles-components-card">
            <div class="skittles-components-card__icon skittles-components-card__icon--disabled">
                <svg class="icon">
                    <use xlink:href="#close" />
                </svg>
            </div>
            <div class="skittles-components-card__title">Disabled</div>
        </div>
    </div>
</label>
```